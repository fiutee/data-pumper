namespace DataPumper.Web.DataLayer
{
    public class Setting
    {
        public const string CurrentDateTable = "CurrentDateTable";
        public const string CurrentDateField = "CurrentDateField";
        public const string Cron = "Cron";

        public string Key { get; set; }
        public string Value { get; set; }
    }
}