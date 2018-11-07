using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            castComboBox.Visible = false;
            moviesListBox.Items.Clear();
            castComboBox.Items.Clear();
            DescLabel.Text = "";
            HeadLabel.Text = "";
            WebClient wc = new WebClient();
            string html = wc.DownloadString("https://www.imdb.com/find?ref_=nv_sr_fn&q="+searchTextBox.Text.Trim()+"&s=all");
            string startKey = "<h3 class=\"findSectionHeader\"><a name=\"tt\"></a>Titles</h3>";
            string endKey = "</table>";
            string resultStartKey = "<td class=\"result_text\"> ";
            string resultEndKey = "</td>";
            int startIndex = html.IndexOf(startKey);
            int endIndex = html.IndexOf(endKey, startIndex);
            html = html.Substring(startIndex, (endIndex - startIndex));
            int searchStartIndex;
            int searchEndIndex = 0;

            List<Movie> movies = new List<Movie>();

            while (true)
            {
                if (html.IndexOf(resultStartKey, searchEndIndex) < 0) break;
                Movie movie = new Movie();
                searchStartIndex = html.IndexOf(resultStartKey, searchEndIndex);
                searchEndIndex = html.IndexOf(resultEndKey, searchStartIndex);
                string result = html.Substring(searchStartIndex, (searchEndIndex - searchStartIndex));
                //aşağı kısım ayrı ayrı metodlarda yapılsa çok tatlı olur
                string linkStartKey = "<a href=\"";
                int linkStartIndex = result.IndexOf(linkStartKey) + linkStartKey.Length;
                string linkEndKey = "\" >";
                int linkEndIndex = result.IndexOf(linkEndKey);
                string link = result.Substring(linkStartIndex, (linkEndIndex - linkStartIndex));
                movie.link = link;

                int nameStartIndex = linkEndIndex + linkEndKey.Length;
                string nameEndKey = "</a>";
                int nameEndIndex = result.IndexOf(nameEndKey, nameStartIndex);
                string name = result.Substring(nameStartIndex, (nameEndIndex - nameStartIndex));
                movie.name = name;

                string year = result.Substring(nameEndIndex + nameEndKey.Length, 7).Trim();
                movie.year = year;

                movies.Add(movie);
                
            }

            foreach(Movie d in movies)
            {
                moviesListBox.Items.Add(d);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Boş tıklanıldığında hata vermesi nasıl engellenir ?
            castComboBox.Visible = true;
            castComboBox.Items.Clear();
            Movie movie = (Movie)moviesListBox.SelectedItem;
            WebClient wc = new WebClient();
            string html = wc.DownloadString("https://www.imdb.com" + movie.link);

            string ratingStartText = "<span itemprop=\"ratingValue\">";
            int ratingStartIndex = html.IndexOf(ratingStartText)+ratingStartText.Length;
            string rating = html.Substring(ratingStartIndex, 3);
            movie.rating = rating;

            string descStartText = "<div class=\"summary_text\">";
            int descStartIndex = html.IndexOf(descStartText)+descStartText.Length;
            string descEndText = "<";
            int descEndIndex = html.IndexOf(descEndText, descStartIndex);
            string desc = html.Substring(descStartIndex, (descEndIndex - descStartIndex)).Trim();
            movie.desc = desc;

            HeadLabel.Text = movie.name.ToUpper()+"("+movie.rating+")";
            DescLabel.Text = movie.desc;

            string castHtmlStartKey = "<h2>Cast</h2>";
            int castHtmlStartIndex = html.IndexOf(castHtmlStartKey);
            string castHtmlEndKey = "</table>";
            int castHtmlEndIndex = html.IndexOf(castHtmlEndKey, castHtmlStartIndex);
            string castHtml = html.Substring(castHtmlStartIndex, (castHtmlEndIndex - castHtmlStartIndex));

            string castLinkStartKey = "<td class=\"primary_photo\">";
            int castLinkStartIndex;
            string castLinkEndKey = "\"";
            int castLinkEndIndex;
            string castNameStartKey = "alt=\"";
            int castNameStartIndex;
            string castNameEndKey = "\"";
            int castNameEndIndex=0;
            List<Cast> casts = new List<Cast>();
            while (true)
            {
                if (castHtml.IndexOf(castLinkStartKey,castNameEndIndex) < 0) break;
                Cast cast = new Cast();
                castLinkStartIndex = castHtml.IndexOf(castLinkStartKey, castNameEndIndex)+castLinkStartKey.Length+("<a href=\"/".Length);
                castLinkEndIndex = castHtml.IndexOf(castLinkEndKey, castLinkStartIndex);
                string castLink = castHtml.Substring(castLinkStartIndex, (castLinkEndIndex - castLinkStartIndex));
                cast.link = castLink;

                castNameStartIndex = castHtml.IndexOf(castNameStartKey, castLinkEndIndex)+castNameStartKey.Length;
                castNameEndIndex = castHtml.IndexOf(castNameEndKey, castNameStartIndex);
                string castName = castHtml.Substring(castNameStartIndex, (castNameEndIndex - castNameStartIndex));
                cast.name = castName;

                casts.Add(cast);
            }
            foreach (Cast c in casts)
            {
                castComboBox.Items.Add(c);
            }

        }

        private void castComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CastForm castForm = new CastForm();
            castForm.cast =(Cast) castComboBox.SelectedItem;

            WebClient wc = new WebClient();
            string castHtml = wc.DownloadString("https://www.imdb.com" + castForm.cast.link);

            string castBioStartKey = "<div class=\"inline\">";
            int castBioStartIndex = castHtml.IndexOf(castBioStartKey)+castBioStartKey.Length;
            int castBioEndIndex = castHtml.IndexOf("<", castBioStartIndex);
            string CastBio = castHtml.Substring(castBioStartIndex, (castBioEndIndex - castBioStartIndex)).Trim();
            castForm.cast.bio = CastBio;

            string castBornStartKey = "<time datetime=\"";
            if (castHtml.IndexOf(castBornStartKey) > 0)
            {
                int castBornStartIndex = castHtml.IndexOf(castBornStartKey) + castBornStartKey.Length;
                int castBornEndIndex = castHtml.IndexOf("\">", castBornStartIndex);
                string castBorn = castHtml.Substring(castBornStartIndex, (castBornEndIndex - castBornStartIndex));
                castForm.cast.born = castBorn;
            }



            castForm.ShowDialog();
        }
    }
}
