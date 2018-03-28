using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using static RTFtoJPEG.Graphics_DrawRtfText;
using System.IO;
using System.Configuration;

namespace RTFtoJPEG
{
    static class Program
    {
        public static string fileName;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
#if !DEBUG
            try
            {
#endif
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                rtfDrawer = new RichTextBoxDrawer();
                rtfDrawer.BackColor = Color.White;
                if (args.Count() == 0)
                {
#if DEBUG
                args = new string[] { "C:\\Program Files (x86)\\Ostendo\\Applications\\OrderForm\\RTF\\20170914_0001_Comments.rtf" };
#endif
#if !DEBUG
                    args = new string[] { Path.Combine(ConfigurationManager.AppSettings["path"], "20170914_0001_Comments.rtf") };
#endif
                }
                fileName = args[0];
                string temp = Path.GetFileName(args[0]);
                MessageBox.Show("path is " + Path.Combine(ConfigurationManager.AppSettings["path"], temp));
                rtfDrawer.LoadFile(Path.Combine(ConfigurationManager.AppSettings["path"] ,temp));
                rtfDrawer.Width = 555;
                var point = rtfDrawer.GetPositionFromCharIndex(rtfDrawer.Text.Length - 1);
                rtfDrawer.Select(rtfDrawer.Text.Length - 1, 1);
                point = new Point(point.X, point.Y + rtfDrawer.SelectionFont.Height);
                rtfDrawer.Height = point.Y + 10;

                using (Graphics g = rtfDrawer.CreateGraphics())
                {
                    g.Clear(Color.White);
                    g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    g.DrawRtfText(rtfDrawer.Rtf, rtfDrawer.Bounds, 1.2f);
                }
#if !DEBUG
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace + e.Message);
                Log(e.Message);
            }
#endif
        }
        public static void Log(string logMessage)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", logMessage);
                w.WriteLine("-------------------------------");
            }
        }
    }
}
