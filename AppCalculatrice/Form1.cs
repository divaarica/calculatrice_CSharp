using System.Data;
using System.Dynamic;

namespace AppCalculatrice
{
    public partial class Form1 : Form
    {
        string curentOp = "", expression = "", lastTap = "";
        double nb1 = 0;
        int nbrNombre = 0;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Methode pur le clique d'un chiffre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickNumber(object sender, EventArgs e)
        {
            if (txtResult.Text.Length < 9)//le nombre limite de chiffre a entrer est 9
            {
                if (curentOp != "")//pour gerer l'effacement de l'ancien text de txtresult
                {
                    txtResult.Clear();
                    curentOp = "";
                }

                Button chiffre = (Button)sender;

                if (txtResult.Text == "0")// si le text de txtresult == "0" alors "" , pour eviter 01, 000 ...
                {
                    txtResult.Clear();
                }

                txtResult.Text += chiffre.Text;
                lastTap = chiffre.Text;
            }
            else
            {
                txtResult.Text = txtResult.Text;
            }
        }

        /// <summary>
        /// Methode pour le clique d'un operateur parmis les suivant (+,-,*./)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickOp(object sender, EventArgs e)
        {
            Button operateur = (Button)sender;
            if (curentOp != operateur.Text)
            {
                /*le if ici permet de gerer le fai que si un utilisateur tape a la suite 2 operateur,
                c'est le dernier aui sera pris en compte */
                if (lastTap == "-" || lastTap == "+" || lastTap == "*" || lastTap == "/")
                {
                    expression = expression.Substring(0, expression.Length - 2);
                    //txtResult.Text = expression;
                }
                expression += txtResult.Text;
                curentOp = operateur.Text;
                expression += operateur.Text;
                lastTap = operateur.Text;
            }



        }

        /// <summary>
        /// Methode pour le clique du egal(=)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEgal(object sender, EventArgs e)
        {
            /*on va recuperer la derniere valeur de txtresult seulement si le dernier clique de
            l'utilisateur n'est pas un opereteur (+,-,/,*), si on ne met pas cette condition , si on clique
            par exemple sur 7+3+ alors le resultat sera 7+3+3 = 13 */
            if (lastTap != "" && lastTap != "+" && lastTap != "-" && lastTap != "*" && lastTap != "/")
            {
                expression += txtResult.Text;
            }

            try
            {
                /* Compute est une methode de la classe DataTable qui permet d'evaluer une expression
                dans ce cas, il se chargera de faire l'operation contenue dans l'expression */

                double v = double.Parse(dt.Compute(expression, "").ToString());

                if (v.ToString() == "NaN") // pour gerer l'operation 0/0 qui donne NaN
                {
                    txtResult.Text = "Error";
                }
                else if (double.IsInfinity(v))// pour gerer une operetion nb../0 qui donne l'infini
                {
                    txtResult.Text = "Error";
                }
                else
                {
                    txtResult.Text = v.ToString().Replace(",", ".");
                }
                expression = ""; // a la fin du calcul l'expression doit etre vide pour effectuer d'autres operations
                curentOp = "=";
                lastTap = "";

            }
            catch
            {
                txtResult.Text = "SyntaxError";
                expression = "";
            }

        }

        /// <summary>
        /// Methode pour le CE (Clear Entry) qui permet d'effacer la derniere entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCE(object sender, EventArgs e)
        {
            int longeur = txtResult.Text.Length;
            if (longeur == 1)
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = txtResult.Text.Substring(0, longeur - 1);
            }

        }

        /// <summary>
        /// Methode pour le AC (All Clear) qui permet d'effacer toute les donnes de l'ecran et reinitialise tout a 0;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAC(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            curentOp = "";
            expression = "";
            lastTap = "";
        }

        /// <summary>
        /// Methode de fermeture ou arret de la fenetre de la calculatrice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Methode de reduction de la fenetre de la calculatrice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Methode d'agrandissement de la fenetre de la calculatrice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }


        /// <summary>
        /// Methode pour le clique de la virgule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickVirgule(object sender, EventArgs e)
        {
            if (txtResult.Text.Length < 9)
            {
                Button virgule = (Button)sender;
                if (txtResult.Text != "") // verifiaction que txtResult a une un expression
                {
                    // si txtResult ne contient pas de virgule alors on met sinon txtResult ne change pas
                    if (!txtResult.Text.Contains("."))
                    {
                        txtResult.Text += virgule.Text;
                    }
                    else
                    {
                        txtResult.Text = txtResult.Text;
                    }
                }
            }
            else
            {
                txtResult.Text = txtResult.Text;
            }
        }

        /// <summary>
        /// Cette methode permet d'ajouter un moin devant un nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickMoinsPlus(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '-')
            {
                txtResult.Text = txtResult.Text.Substring(1,txtResult.Text.Length-1);
            }
            else
            {
                txtResult.Text = "-" + txtResult.Text;
            }

        }

        /* /// <summary>
        /// Methode pour le clique du poucentage (%)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickPoucentage(object sender, EventArgs e)
        {
            Button poucentage = (Button)sender;

            // il y a une difference netre (.. + nb%) et (nb% + ..), le premier additione l'espression au pourcentage du nombre
             //(nb/100) et le deuxiemme addition l'expression(..) au poucentage du nombre fois le nombre (nb/100 * nb) 
            if (poucentage.Text == "%")
            {
                if (expression == "")
                {
                    txtResult.Text = (double.Parse(txtResult.Text.Replace(".", ",")) / 100).ToString().Replace(",", ".");
                }
                else
                {
                    double v = double.Parse(dt.Compute(expression.Substring(0, expression.Length - 1), "").ToString());
                    double result = (double.Parse(txtResult.Text) / 100) * v;
                    txtResult.Text = result.ToString().Replace(",", ".");
                }
            }

        } */

        /* switch (curentOp)
            {
                case "+":
                    txtResult.Text = (nb1 + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (nb1 - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (nb1 * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (nb1 / double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;

            } */


    }




}

