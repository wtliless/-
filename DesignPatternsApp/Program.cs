using Singleton;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取人名
            NameValueCollection nvc = (NameValueCollection)ConfigurationManager.GetSection("Person");
            foreach (string key in nvc.AllKeys)
            {
                Console.WriteLine(key + ":" + nvc[key]);
            }

            //读取男人
            IDictionary dict = (IDictionary)ConfigurationManager.GetSection("Man");
            foreach (string key in dict.Keys)
            {
                Console.WriteLine(key + ":" + dict[key]);
            }

            IDictionary dict1 = (IDictionary)ConfigurationManager.GetSection("Name");
            foreach (string key in dict1.Keys)
            {
                Console.WriteLine(key + ":" + dict1[key]);
            }

            Console.ReadKey();


            CreateAppSettings();
            //SingleObject singleObject = SingleObject.GetSingleObject();
            //var singleResult = singleObject.ShowMessage();
            //Console.WriteLine(singleResult);


            Test3 test = new Test3();
            test.VirtualTest();
        }

        // Create the AppSettings section.
        // The function uses the GetSection(string)method 
        // to access the configuration section. 
        // It also adds a new element to the section collection.
        public static void CreateAppSettings()
        {
            // Get the application configuration file.
            Configuration config =
              ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);

            string sectionName = "appSettings";

            // Add an entry to appSettings.
            int appStgCnt =
                ConfigurationManager.AppSettings.Count;
            string newKey = "NewKey" + appStgCnt.ToString();

            string newValue = DateTime.Now.ToLongDateString() +
              " " + DateTime.Now.ToLongTimeString();

            config.AppSettings.Settings.Add(newKey, newValue);

            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of the changed section. This 
            // makes the new values available for reading.
            ConfigurationManager.RefreshSection(sectionName);

            // Get the AppSettings section.
            AppSettingsSection appSettingSection =
              (AppSettingsSection)config.GetSection(sectionName);

            Console.WriteLine();
            Console.WriteLine("Using GetSection(string).");
            Console.WriteLine("AppSettings section:");
            Console.WriteLine(
              appSettingSection.SectionInformation.GetRawXml());
        }

    }

    public abstract class Test
    {
        public virtual void VirtualTest()
        {
            VirtualTest1();
        }


        public virtual void VirtualTest1()
        {

        }
    }

    public abstract class Test2: Test
    {
        public override void VirtualTest()
        {
        }

        public override void VirtualTest1()
        {
            base.VirtualTest1();
        }
    }

    public class Test3 : Test
    {
        
    }


}
