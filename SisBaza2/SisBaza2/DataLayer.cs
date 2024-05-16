using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using SisBaza2.Mapiranja;

namespace SisBaza2
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        //ovo nam je mutex
        private static object objLock = new object();

        //ovo nam vraca sesiju
        public static ISession GetSession()
        {
            if(_factory == null)
            {
                lock(objLock)
                {
                    if (_factory == null)
                    {
                        _factory = CreateSessionFactory();
                    }
                }
            }
            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try 
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ConnectionString(c =>
                        c.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=<username>;Password=<pass>"));
                return Fluently.Configure()
                    .Database(cfg.ShowSql())
                    //nije bitno koj stavimo jer povlaci preko namespaca
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<narodniPoslanikMapiranja>())
                    .BuildSessionFactory();
            } 
            catch (Exception ec) 
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }
        }

    }
}
