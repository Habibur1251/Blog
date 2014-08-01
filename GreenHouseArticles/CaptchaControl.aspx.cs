using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

public partial class CaptchaControl : System.Web.UI.Page
{
    private Random rand = new Random();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CreateImage();
        }
    }

    private void CreateImage()
    {
        string code = GetRandomText();

        Bitmap bitmap = new Bitmap(200, 50, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

        Graphics g = Graphics.FromImage(bitmap);
        Pen pen = new Pen(Color.Yellow);
        Rectangle rect = new Rectangle(0, 0, 200, 50);

        SolidBrush b = new SolidBrush(Color.DarkKhaki);
        SolidBrush blue = new SolidBrush(Color.Blue);

        int counter = 0;

        g.DrawRectangle(pen, rect);
        g.FillRectangle(b, rect);

        for (int i = 0; i < code.Length; i++)
        {
            g.DrawString(code[i].ToString(), new Font("Verdena", 10 + rand.Next(14, 18)), blue, new PointF(10 + counter, 10));
            counter += 20;
        }

        DrawRandomLines(g);

        bitmap.Save(Response.OutputStream, ImageFormat.Gif);

        g.Dispose();
        bitmap.Dispose();

    }

    private void DrawRandomLines(Graphics g)
    {
        SolidBrush green = new SolidBrush(Color.Green);
        for (int i = 0; i < 10; i++)
        {
            g.DrawLines(new Pen(green, 2), GetRandomPoints());
        }

    }

    private Point[] GetRandomPoints()
    {
        Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
        return points;
    }

    private string GetRandomText()
    {
        StringBuilder randomText = new StringBuilder();

        if (Session["Code"] == null)
        {
            string alphabets = "abcdejktuvwxyzABCDEFGHVWXYZ123789";

            Random r = new Random();
            for (int j = 0; j <=6; j++)
            {

                randomText.Append(alphabets[r.Next(alphabets.Length)]);
            }

            Session["Code"] = randomText.ToString();
        }

        return Session["Code"] as String;
    }

}
