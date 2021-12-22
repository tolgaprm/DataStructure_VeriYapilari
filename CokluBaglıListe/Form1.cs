using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluBaglıListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        
        }


        class Dugum
        {
            public int numara;

            public Dugum sonraki;

            public Dugum(int numara)
            {
                this.numara = numara;
            }
        }

        class CiftDugum
        {
            public int kod;
            public string ad;
            public int fiyat;

            public CiftDugum sonraki;
            public CiftDugum onceki;

            public CiftDugum(int kod, string ad, int fiyat)
            {
                this.kod = kod;
                this.ad = ad;
                this.fiyat = fiyat;
            }
 
        }

        CiftDugum ilk = null;
        CiftDugum son = null;

        private void btnEkle_Click(object sender, EventArgs e)
        {
           

            if (hataMesaj.Visible)
            {
                hataMesaj.Visible = false;
            }
           
            int girilenKod = Convert.ToInt32(urunEkleKod.Text);
            string ad = urunEkleAd.Text;
            int fiyat = Convert.ToInt32(urunEkleFiyat.Text);

            
            CiftDugum yeni = new CiftDugum(girilenKod, ad, fiyat);

           

            if (ilk == null)
            {
                ilk = yeni;
                ilk.onceki = null;
                ilk.sonraki = null;
                son = ilk;

            }
            else
            {
                CiftDugum gecici = ilk;

                while (gecici != null)
                {
                    if(yeni.kod == gecici.kod)
                    {
                        hataMesaj.Visible = true;
                        break;
                    }

                    gecici = gecici.sonraki;
                }

                if (hataMesaj.Visible == false)
                {
                    son.sonraki = yeni;
                    yeni.onceki = son;
                    yeni.sonraki = null;
                    son = yeni;
                }
              

            }


            urunEkleKod.Text = "";
            urunEkleAd.Text = "";
            urunEkleFiyat.Text = "";

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int girilenfiyat = Convert.ToInt32(urunGuncelleFiyat.Text);
            
            CiftDugum gecici = ilk;
            int girilenKod = Convert.ToInt32(urunGuncelleKod.Text);


            while (gecici != null)
            {
                if(gecici.kod == girilenKod)
                {
                    gecici.fiyat = girilenfiyat;
                    break;
                }
                gecici = gecici.sonraki;
            }

            btnGüncelle.Enabled = false;

            urunGuncelleAd.Text = "";
            urunGuncelleFiyat.Text = "";
            urunGuncelleKod.Text = "";

        }

        private void urunGuncellemeBul_Click(object sender, EventArgs e)
        {

            
            urunGuncellemeHata.Visible = false;
            urunGuncelleFiyat.Enabled = false;

            int girilenKod = Convert.ToInt32(urunGuncelleKod.Text);

            CiftDugum gecici = ilk;
            Boolean aynıKodVarmi = false;

            while (gecici != null)
            {
                if (gecici.kod == girilenKod)
                {
                    urunGuncelleAd.Text = gecici.ad;
                    urunGuncelleFiyat.Text = gecici.fiyat.ToString();
                    aynıKodVarmi = true;
                    btnGüncelle.Enabled = true;
                    urunGuncelleFiyat.Enabled = true;
                    break;
                }

                gecici = gecici.sonraki;
            }

            if (aynıKodVarmi == false)
            {
                urunGuncellemeHata.Visible = true;
                urunGuncelleAd.Text = "";
                urunGuncelleFiyat.Text = "";
              
            }

            

        }

        private void urunSilmeBul_Click(object sender, EventArgs e)
        {
            hataMesajSilme.Visible = false;



            int girilenKod = Convert.ToInt32(urunSilmeKod.Text);

            Boolean aynıKodVarmi = false;
            CiftDugum gecici = ilk;

            while (gecici != null)
            {
                if (gecici.kod == girilenKod)
                {
                    urunSilmeAd.Text = gecici.ad;
                    urunSilmeFiyat.Text = gecici.fiyat.ToString();
                    aynıKodVarmi = true;
                    btnSil.Enabled = true;
                    break;
                }

                gecici = gecici.sonraki;
            }

            if (aynıKodVarmi == false)
            {
                hataMesajSilme.Visible = true;
                btnSil.Enabled = false;
                urunSilmeAd.Text = "";
                urunSilmeFiyat.Text = "";

            }

            


        }

        private void btnUrunleriListele_Click(object sender, EventArgs e)
        {

            dataGridView.Rows.Clear();
            

            CiftDugum gecici = ilk;
            int rows = 0;

            
            while(gecici != null)
            {

                dataGridView.Rows.Add();

                dataGridView.Rows[rows].Cells[0].Value = gecici.kod.ToString();

                dataGridView.Rows[rows].Cells[1].Value = gecici.ad;

                dataGridView.Rows[rows].Cells[2].Value = gecici.fiyat.ToString();
                    
                rows += 1;
               
                gecici = gecici.sonraki;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CiftDugum silinecek = ilk;
            

            int girilenKod = Convert.ToInt32(urunSilmeKod.Text);

            while(silinecek != null)
            {
                if(silinecek.kod == girilenKod)
                {
                 
                    if(silinecek == ilk && ilk.sonraki == null)
                    {
                        ilk = null;
                       
                    }
                    else if(silinecek == ilk)
                    {
                        ilk = ilk.sonraki;
                        ilk.onceki = null;

                    }
                    else if ( silinecek == son)
                    {
                        son = son.onceki;
                        son.sonraki = null;
                    }
                    else
                    {
                        silinecek.onceki.sonraki = silinecek.sonraki;
                        silinecek.sonraki.onceki = silinecek.onceki;
                    }

                    
                }

                silinecek = silinecek.sonraki;
            }

            urunSilmeKod.Text = "";
            urunSilmeAd.Text = "";
            urunSilmeFiyat.Text = "";

        }

       

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            urunSilmeKod.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            urunSilmeAd.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            urunSilmeFiyat.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            urunGuncelleKod.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            urunGuncelleAd.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            urunGuncelleFiyat.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            btnSil.Enabled = true;
            btnGüncelle.Enabled = true;

            urunGuncelleFiyat.Enabled = true;

            
        }



        Dugum ilkStack = null;
        Dugum sonStack = null;

        private void btnEkleStack_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(stackYeniEkle.Text);

            Dugum yeni = new Dugum(no);

            if(yeni == null)
            {
                ilkStack = yeni;
                ilkStack.sonraki = null;
                sonStack = ilkStack;
            }
            else
            {
                yeni.sonraki = ilkStack;
                ilkStack = yeni;
            }

            dataGridViewStack.Rows.Clear();
            int rows = 0;
            Dugum gecici = ilkStack;
            while (gecici != null)
            {
                dataGridViewStack.Rows.Add();

                dataGridViewStack.Rows[rows].Cells[0].Value = gecici.numara.ToString();

                rows++;
                gecici = gecici.sonraki;
            }

            stackYeniEkle.Text = "";
        }

        private void btnCıkarStack_Click(object sender, EventArgs e)
        {
             if(ilkStack == null)
            {
                ilkStack = null;
            }
            else
            {
                ilkStack = ilkStack.sonraki;
            }

            Dugum gecici = ilkStack;
            dataGridViewStack.Rows.Clear();
            int rows = 0;

            while (gecici != null)
            {
                dataGridViewStack.Rows.Add();

                dataGridViewStack.Rows[rows].Cells[0].Value = gecici.numara.ToString();

                rows ++;

                gecici = gecici.sonraki;

            }


        }

        private void Stack_Click(object sender, EventArgs e)
        {

        }

        private void btnMatematikselIfadeyiKontrolEt_Click(object sender, EventArgs e)
        {
            matIfadeHata.Visible = false;
            String matIfade = txtMatematikselIfade.Text;


            Char[] arrayMatDizi= matIfade.ToCharArray();


            Stack<Char> stack = new Stack<Char>();


            for (int i = 0; i < arrayMatDizi.Length; i++)
            {

                
                if (arrayMatDizi[i] == '(' || arrayMatDizi[i] == '[' || arrayMatDizi[i] == '{')
                {
                    stack.Push(arrayMatDizi[i]);
                   
                }
                else if (arrayMatDizi[i] == ')' || arrayMatDizi[i] == ']' || arrayMatDizi[i] == '}')
                {
                    if(stack.Count == 0)
                    {
                        matIfadeHata.Visible = true;
                    }
                    else {
                        char a = '(';
                        if(stack.Peek() == '(')
                        {
                            a = ')';
                        }else if(stack.Peek() == '[')
                        {
                            a = ']';
                        }else if(stack.Peek() == '{')
                        {
                            a = '}';
                        }
                       


                        if(arrayMatDizi[i] != a)
                        {
                            matIfadeHata.Visible = true;
                        }
                        else
                        {
                            stack.Pop();
                        }

                        
                    }
                }

                if (i == arrayMatDizi.Length - 1)
                {
                    if (stack.Count != 0)
                    {
                        matIfadeHata.Visible = true;
                    }
                }


            }



        }
    }
}
