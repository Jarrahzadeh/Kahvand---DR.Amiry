using System;
using System.IO;
using System.Text;

namespace Ophthalmology.Utility.Helpers
{
    public static class ExceptionHelper
    {
        public static void Log(this Exception exception)
        {
            var filePath = Path.Combine("Log", $"{DateTime.Now.ToString("yyyy-MM-dd", CultureHelper.PersianCulture)}.log");
            if (!Directory.Exists("Log"))
                Directory.CreateDirectory("Log");

            var contents = string.Format("{0}{1}Message:{1}{2}{1}CallStack:{1}{3}{1}{1}", $"{DateTime.Now:HH:mm:ss.fffff} ".PadRight(150, '-'), Environment.NewLine, exception.GetMessage(), exception.StackTrace);
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, contents, Encoding.UTF8);
            }
            else
            {
                File.AppendAllText(filePath, contents, Encoding.UTF8);
            }
        }

        public static string GetMessage(this Exception exception)
        {
            return exception == null ?
                string.Empty :
                $"{exception.Message}{Environment.NewLine}{exception.InnerException.GetMessage()}";
        }
    }
}
