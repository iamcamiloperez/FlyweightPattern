using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlyweightPattern
{
    public partial class Index : System.Web.UI.Page
    {
        #region properties
        List<Player> players = null;
        Player player = null;
        #endregion

        #region load methods
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                start(new object(), new EventArgs());
            }
        }

        #endregion

        #region event methods

        protected void btn_Click(object sender, EventArgs e)
        {
            Button button;            
            if (sender is Button)
            {
                button = sender as Button;
                players = Session["Players"] as List<Player>;
                string x = button.ID.Substring(3);
                player = players.ElementAt(Convert.ToInt32(button.ID.Substring(3))-1);
                button.BackColor = player.playerValues.getColor();                
                button.Text = player.getNumber().ToString();
                if(player.playerValues.number == 0)
                {
                    button.Text = "You lose";
                    if (button.ID == "btn1")
                        btn2.Text = "You win";
                    else
                        btn1.Text = "You win";

                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    player.playerValues.number = 10000;
                }

            }
        }

        protected void start(object sender, EventArgs e)
        {
            players = new List<Player>();
            players.Add(new Player(1));
            players.Add(new Player(2));
            Session["Players"] = players;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn1.Text = btn2.Text = "Start";
        }        

            #endregion
        }
}