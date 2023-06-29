using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testeDownload
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_download_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("linha1");
            sb.AppendLine("linha2");

            var byteArray = Encoding.UTF8.GetBytes(sb.ToString());

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentType = "text/plain";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=arquivo.txt");

            // Escrever o array de bytes no fluxo de resposta
            HttpContext.Current.Response.BinaryWrite(byteArray);

            // Finalizar a resposta
            HttpContext.Current.Response.End();
        }
    }
}