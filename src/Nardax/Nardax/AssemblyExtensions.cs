using System;
using System.Configuration;
using System.Reflection;

namespace Nardax
{
    /// <summary>
    //Hello World
    // Damn this is fun!
    /// </summary>
    public static class AssemblyExtensions
    {

        //Hitta Appsettings värden utifrån Assembly
        public static string GetAppSettingsValue(this Assembly assembly, string key)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(assembly.Location);

            if (configuration.AppSettings.Settings[key] != null)
            {
                return configuration.AppSettings.Settings[key].Value;
            }

            throw new IndexOutOfRangeException(string.Format(ExceptionMessages.SettingsKeyNotFound, key));
        }
    }
}
DF
    SDF
    SDFASDF
    ASD
    FA
    SDF
    ASDF
    SAD
