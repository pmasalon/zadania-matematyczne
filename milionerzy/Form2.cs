namespace milionerzy
{
    public partial class Form2 : Form
    {
        private int punkty = 0;
        private int zadanie = 1;
        private int ticks;
        private int odp;
        private int od;
        private int trudnosc;
        int i = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            this.label4.Text = ticks.ToString();
            if (zadanie == 11)
            {
                timer1.Stop();
                string message =
                "TWOJE PUNKTY: " + punkty + "/10 CZAS: " + ticks + " /30 SEK";
                const string caption = "ZADANIA UKOŃCZONE!";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.OK) this.Close();
            }
            if (ticks == 30)
            {
                timer1.Stop();
                string message =
                "TWOJE PUNKTY: " + punkty + "/10";
                const string caption = "KONIEC CZASU!";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.OK) this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            timer1.Start();
            od = 1;
            trudnosc = 11;
            zadania(od, trudnosc);

        }
        private void zadania(int od, int trudnosc)
        {
                //losowanie znaku
                int jaki_znak;
                if (od == 1)
                {
                    Random znak = new Random();
                    jaki_znak = znak.Next(1, 4);
                }
                else
                if (od == 11)
                {
                    Random znak = new Random();
                    jaki_znak = znak.Next(2, 4);
                }
                else
                {
                    jaki_znak = 3;
                }
                //----------------

                //losowanie 2 liczb do działania
                Random pierwszy = new Random();
                int a = pierwszy.Next(od, trudnosc);
                Random drugi = new Random();
                int b = drugi.Next(od, trudnosc);
                //--------------------------------

                switch (jaki_znak)
                {
                    case 1:
                        label2.Text = "Ile jest: " + a + " + " + b; //pytanie
                        odp = a + b;
                        label10.Text = i.ToString(); //nr zadania

                        //losowanie buttona z odp
                        Random random = new Random();
                        int o = random.Next(1, 5);
                        switch (o)
                        {
                            case 1:
                                button3.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int odp2 = odp + 1;
                                int odp3 = odp - 1;
                                int odp4 = odp + 2;
                                button4.Text = odp2.ToString();
                                button5.Text = odp3.ToString();
                                button7.Text = odp4.ToString();
                                break;
                            case 2:
                                button4.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int dodp1 = odp + 1;
                                int dodp3 = odp - 1;
                                int dodp4 = odp + 2;
                                button3.Text = dodp1.ToString();
                                button5.Text = dodp3.ToString();
                                button7.Text = dodp4.ToString();
                                break;
                            case 3:
                                button5.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int todp1 = odp + 1;
                                int todp2 = odp - 1;
                                int todp4 = odp + 2;
                                button3.Text = todp2.ToString();
                                button4.Text = todp1.ToString();
                                button7.Text = todp4.ToString();
                                break;
                            case 4:
                                button7.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int codp1 = odp + 1;
                                int codp2 = odp - 1;
                                int codp3 = odp + 2;
                                button3.Text = codp2.ToString();
                                button4.Text = codp1.ToString();
                                button5.Text = codp3.ToString();
                                break;
                        }
                       
                        break;
                    case 2:
                        if (b > a) { int c = a; a = b; b = c; }
                        label2.Text = "Ile jest: " + a + " - " + b; //pytanie
                        odp = a - b;
                        label10.Text = i.ToString(); //nr zadania

                        //losowanie buttona z odp
                        Random rrandom = new Random();
                        int oo = rrandom.Next(1, 5);
                        switch (oo)
                        {
                            case 1:
                                button3.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int odp2 = odp + 1;
                                int odp3 = odp - 1;
                                int odp4 = odp + 2;
                                button4.Text = odp2.ToString();
                                button5.Text = odp3.ToString();
                                button7.Text = odp4.ToString();
                                break;
                            case 2:
                                button4.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int dodp1 = odp + 1;
                                int dodp3 = odp - 1;
                                int dodp4 = odp + 2;
                                button3.Text = dodp1.ToString();
                                button5.Text = dodp3.ToString();
                                button7.Text = dodp4.ToString();
                                break;
                            case 3:
                                button5.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int todp1 = odp + 1;
                                int todp2 = odp - 1;
                                int todp4 = odp + 2;
                                button3.Text = todp2.ToString();
                                button4.Text = todp1.ToString();
                                button7.Text = todp4.ToString();
                                break;
                            case 4:
                                button7.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int codp1 = odp + 1;
                                int codp2 = odp - 1;
                                int codp3 = odp + 2;
                                button3.Text = codp2.ToString();
                                button4.Text = codp1.ToString();
                                button5.Text = codp3.ToString();
                                break;
                        }
                        
                        break;
                    case 3:
                        label2.Text = "Ile jest: " + a + " * " + b; //pytanie
                        odp = a * b;
                        label10.Text = i.ToString(); //nr zadania

                        //losowanie buttona z odp
                        Random rrrandom = new Random();
                        int ooo = rrrandom.Next(1, 5);
                        switch (ooo)
                        {
                            case 1:
                                button3.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int odp2 = odp + 1;
                                int odp3 = odp - 1;
                                int odp4 = odp + 2;
                                button4.Text = odp2.ToString();
                                button5.Text = odp3.ToString();
                                button7.Text = odp4.ToString();
                                break;
                            case 2:
                                button4.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int dodp1 = odp + 1;
                                int dodp3 = odp - 1;
                                int dodp4 = odp + 2;
                                button3.Text = dodp1.ToString();
                                button5.Text = dodp3.ToString();
                                button7.Text = dodp4.ToString();
                                break;
                            case 3:
                                button5.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int todp1 = odp + 1;
                                int todp2 = odp - 1;
                                int todp4 = odp + 2;
                                button3.Text = todp2.ToString();
                                button4.Text = todp1.ToString();
                                button7.Text = todp4.ToString();
                                break;
                            case 4:
                                button7.Text = odp.ToString();
                                //tworzenie fałszywych odpowiedzi
                                int codp1 = odp + 1;
                                int codp2 = odp - 1;
                                int codp3 = odp + 2;
                                button3.Text = codp2.ToString();
                                button4.Text = codp1.ToString();
                                button5.Text = codp3.ToString();
                                break;
                        }
                        
                        break;
                }
                //zatrzymać i ruszyć .............. po kliknięciu zablokować resztę
                i++;
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            timer1.Start();
            od = 5;
            trudnosc = 13;
            zadania(od, trudnosc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            timer1.Start();
            od = 10;
            trudnosc = 16;
            zadania(od, trudnosc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(button3.Text) == odp)
            {
                punkty++;
                label8.Text = punkty.ToString();
                zadanie++;
                if(zadanie<11)zadania(od, trudnosc);

            }
            else
            {
                zadanie++;
                if (zadanie < 11) zadania(od, trudnosc);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(button4.Text) == odp)
            {
                punkty++;
                label8.Text = punkty.ToString();
                zadanie++;
                if (zadanie < 11) zadania(od, trudnosc);
            }
            else
            {
                zadanie++;
                if (zadanie < 11) zadania(od, trudnosc);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(button5.Text) == odp)
            {
                punkty++;
                label8.Text = punkty.ToString();
                zadanie++;
                if (zadanie < 11) zadania(od, trudnosc);
            }
            else
            {
                zadanie++;
                if (zadanie < 11) zadania(od, trudnosc);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(button7.Text) == odp)
            {
                punkty++;
                label8.Text = punkty.ToString();
                zadanie++;
                if (zadanie < 11) zadania(od, trudnosc);
            }
            else
            {
                zadanie++;
                if (zadanie < 11) zadania(od, trudnosc);
            }
        }
    }
    
}
