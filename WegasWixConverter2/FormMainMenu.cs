using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using static WegasWixConverter2.WixCsv;
using static WegasWixConverter2.WegasCsv;

namespace WegasWixConverter2
{
    public partial class FormMainMenu : MaterialForm
    {
        // Istanzia variabile object readonly materialSkinManager di tipo MaterialSkinManager
        private readonly MaterialSkinManager materialSkinManager;
        // Istanzia variabili object di tipo ColorScheme
        private ColorScheme GreenColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        private ColorScheme RedColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        private ColorScheme OrangeColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        private ColorScheme PurpleColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
        private ColorScheme BlueColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        private ColorScheme CyanColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        private ColorScheme AmberColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.Amber200, TextShade.WHITE);
        private ColorScheme PinkColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE);
        private ColorScheme GreyColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        // Istanzia variabile colors di tipo Generico Dictionary
        private Dictionary<string, ColorScheme> colors = new Dictionary<string, ColorScheme>();
        private string csvFilePath = string.Empty;
        private string csvFilePathCashDesk = string.Empty;
        private string csvFilePathWix = string.Empty;
        private string strWixRecords = string.Empty;
        private string strCashDeskRecords = string.Empty;
        private int indexS = 0;
        private List<WixCsv> WixList = new List<WixCsv>();
        private List<WegasCsv> WegasList = new List<WegasCsv>();
        List<int> searchWixList = new List<int>();
        List<int> searchCashDeskList = new List<int>();
        private WixCsv columnHeader = new WixCsv();

        public FormMainMenu()
        {
            InitializeComponent();
            // Impostazioni Default Tema, Color Scheme, Logo e MaterialCheckBox opzioni
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = RedColorScheme;
            SetLogo(6);
            //SetCheckBoxStateChecked(mchkUpdatePrice);
            //SetCheckBoxStateUnchecked(mchkConsiderReservations);
            //SetCheckBoxStateChecked(mchkSetInvisibleProductX);
            //SetCheckBoxStateUnchecked(mchkSetInvisibleProductWithoutSKU);

            // Aggiunge ColorSchemes al Dictionary colors
            colors.Add("GreenColorScheme", GreenColorScheme);
            colors.Add("RedColorScheme", RedColorScheme);
            colors.Add("OrangeColorScheme", OrangeColorScheme);
            colors.Add("PurpleColorScheme", PurpleColorScheme);
            colors.Add("BlueColorScheme", BlueColorScheme);
            colors.Add("CyanColorScheme", CyanColorScheme);
            colors.Add("AmberColorScheme", AmberColorScheme);
            colors.Add("PinkColorScheme", PinkColorScheme);
            colors.Add("GreyColorScheme", GreyColorScheme);
            // Aggiunge l'intestazione nella lista del csvWix
            columnHeader.HandleId = "handleId";
            columnHeader.FieldType = "fieldType";
            columnHeader.Name = "name";
            columnHeader.Description = "description";
            columnHeader.ProductImageUrl = "productImageUrl";
            columnHeader.Collection = "collection";
            columnHeader.Sku = "sku";
            columnHeader.Ribbon = "ribbon";
            columnHeader.Price = "price";
            columnHeader.Surcharge = "surcharge";
            columnHeader.Visible = "visible";
            columnHeader.DiscountMode = "discountMode";
            columnHeader.DiscountValue = "discountValue";
            columnHeader.Inventory = "inventory";
            columnHeader.Weight = "weight";
            columnHeader.ProductOptionName1 = "productOptionName1";
            columnHeader.ProductOptionType1 = "productOptionType1";
            columnHeader.ProductOptionDescription1 = "productOptionDescription1";
            columnHeader.ProductOptionName2 = "productOptionName2";
            columnHeader.ProductOptionType2 = "productOptionType2";
            columnHeader.ProductOptionDescription2 = "productOptionDescription2";
            columnHeader.ProductOptionName3 = "productOptionName3";
            columnHeader.ProductOptionType3 = "productOptionType3";
            columnHeader.ProductOptionDescription3 = "productOptionDescription3";
            columnHeader.ProductOptionName4 = "productOptionName4";
            columnHeader.ProductOptionType4 = "productOptionType4";
            columnHeader.ProductOptionDescription4 = "productOptionDescription4";
            columnHeader.ProductOptionName5 = "productOptionName5";
            columnHeader.ProductOptionType5 = "productOptionType5";
            columnHeader.ProductOptionDescription5 = "productOptionDescription5";
            columnHeader.ProductOptionName6 = "productOptionName6";
            columnHeader.ProductOptionType6 = "productOptionType6";
            columnHeader.ProductOptionDescription6 = "productOptionDescription6";
            columnHeader.AdditionalInfoTitle1 = "additionalInfoTitle1";
            columnHeader.AdditionalInfoDescription1 = "additionalInfoDescription1";
            columnHeader.AdditionalInfoTitle2 = "additionalInfoTitle2";
            columnHeader.AdditionalInfoDescription2 = "additionalInfoDescription2";
            columnHeader.AdditionalInfoTitle3 = "additionalInfoTitle3";
            columnHeader.AdditionalInfoDescription3 = "additionalInfoDescription3";
            columnHeader.AdditionalInfoTitle4 = "additionalInfoTitle4";
            columnHeader.AdditionalInfoDescription4 = "additionalInfoDescription4";
            columnHeader.AdditionalInfoTitle5 = "additionalInfoTitle5";
            columnHeader.AdditionalInfoDescription5 = "additionalInfoDescription5";
            columnHeader.AdditionalInfoTitle6 = "additionalInfoTitle6";
            columnHeader.AdditionalInfoDescription6 = "additionalInfoDescription6";
            columnHeader.CustomTextField1 = "customTextField1";
            columnHeader.CustomTextCharLimit1 = "customTextCharLimit1";
            columnHeader.CustomTextMandatory1 = "customTextMandatory1";
            columnHeader.CustomTextField2 = "customTextField2";
            columnHeader.CustomTextCharLimit2 = "customTextCharLimit2";
            columnHeader.CustomTextMandatory2 = "customTextMandatory2";
            columnHeader.Brand = "brand";

            // Controlla la Properties impostata e fa il Set Tema, Testo e modifica Stato Switch (Light)
            if (Properties.Settings.Default.ThemeName.Equals("LIGHT"))
            {
                SetThemeAndText(MaterialSkinManager.Themes.LIGHT, "Chiaro");
                mswtTheme.Checked = true;
                SetColorClock();
            }
            // Controlla la Properties ThemeName impostata e fa il Set Tema, Testo e modifica Stato Switch (Dark)
            else if (Properties.Settings.Default.ThemeName.Equals("DARK"))
            {
                SetThemeAndText(MaterialSkinManager.Themes.DARK, "Scuro");
                mswtTheme.Checked = false;
                SetColorClock();
            }
            // Controlla la Properties ColorSchemeName impostata del Color Scheme
            if (!String.IsNullOrEmpty(Properties.Settings.Default.ColorSchemeName))
            {
                try
                {
                    var color = colors[Properties.Settings.Default.ColorSchemeName];
                    if (color != null)
                        materialSkinManager.ColorScheme = color;
                }
                catch (Exception)
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }
        // Evento dello Switch Theme, fa il Set del Theme e Testo
        private void mswtTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.ColorSchemeName))
            {
                SetColorSchemeProperties("RedColorScheme");
                Properties.Settings.Default.Save();
            }
            if (mswtTheme.Checked)
            {
                SetThemeAndText(MaterialSkinManager.Themes.LIGHT, "Chiaro");
            }
            else
            {
                SetThemeAndText(MaterialSkinManager.Themes.DARK, "Scuro");
            }
            // Converte in stringa materialSkinManager.Theme, lo inserisce nella Properties ThemeName e Salva
            Properties.Settings.Default.ThemeName = materialSkinManager.Theme.ToString();
            Properties.Settings.Default.Save();
            SetColorClock();
        }
        // Evento del Radio Button Verde, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(GreenColorScheme, 3, "GreenColorScheme", mrbtnGreen);
        }
        // Evento del Radio Button Rosso, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(RedColorScheme, 6, "RedColorScheme", mrbtnRed);
        }
        // Evento del Radio Button Arancio, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnOrange_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(OrangeColorScheme, 4, "OrangeColorScheme", mrbtnOrange);
        }
        // Evento del Radio Button Viola, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnPurple_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(PurpleColorScheme, 5, "PurpleColorScheme", mrbtnPurple);
        }
        // Evento del Radio Button Blu, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(BlueColorScheme, 1, "BlueColorScheme", mrbtnBlue);
        }
        // Evento del Radio Button Ciano, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnCyan_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(CyanColorScheme, 2, "CyanColorScheme", mrbtnCyan);
        }
        // Evento del Radio Button Ambra, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnAmber_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(AmberColorScheme, 0, "AmberColorScheme", mrbtnAmber);
        }
        // Evento del Radio Button Rosa, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnPink_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(PinkColorScheme, 7, "PinkColorScheme", mrbtnPink);
        }
        // Evento del Radio Button Grigio, fa il Set del Color Scheme, Logo e fa il Set della Properties ColorSchemeName
        private void mrbtnGrey_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedMrbtn(GreyColorScheme, 8, "GreyColorScheme", mrbtnGrey);
        }
        // Evento Double Click tbxCashDeskPath che apre Dialog per selezionare file Csv Cassa
        private void mtbxCashDeskPath_DoubleClick(object sender, EventArgs e)
        {
            LoadCashDeskCsv();
        }
        // Evento Click btnCashDeskLoad che apre Dialog per selezionare file Csv Cassa
        private void mbtnCashDeskLoad_Click(object sender, EventArgs e)
        {
            LoadCashDeskCsv();
        }
        // Evento Click btnCashDeskDelete cancella contenuto tbxCashDeskPath
        private void mbtnCashDeskDelete_Click(object sender, EventArgs e)
        {
            DeleteCashDeskCsv();
        }
        // Evento Double Click tbxWixPath che apre Dialog per selezionare file Csv Wix
        private void mtbxWixPath_DoubleClick(object sender, EventArgs e)
        {
            LoadWixCsv();
        }
        // Evento Click btnWixLoad che apre Dialog per selezionare file Csv Wix
        private void mbtnWixLoad_Click(object sender, EventArgs e)
        {
            LoadWixCsv();
        }
        // Evento Click btnWixDelete cancella contenuto tbxWixPath
        private void mbtnWixDelete_Click(object sender, EventArgs e)
        {
            DeleteWixCsv();
        }
        // Evento Click su Esporta, Cambia la quantità WixList in base a CashDeskList ed esporta il nuovo file CSV Wix
        private void mbtnExportCsv_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mtbxCashDeskPath.Text) && !String.IsNullOrEmpty(mtbxWixPath.Text))
            {
                foreach (var x in WegasList)
                {
                    var itemToChange = WixList.FirstOrDefault(d => d.Sku == x.NumeroArticolo);
                    if (itemToChange != null && itemToChange.Inventory != "InStock" && !mchkConsiderReservations.Checked && mchkUpdateQuantity.Checked)
                    {
                        itemToChange.Inventory = x.StockAttuale;
                        if (mchkUpdatePrice.Checked) {
                            itemToChange.Price = x.PrezziLivello5;
                        }
                    }
                    if (itemToChange != null && itemToChange.Inventory != "InStock" && mchkConsiderReservations.Checked && mchkUpdateQuantity.Checked)
                    {
                        int inventory = int.Parse(x.StockAttuale) - int.Parse(x.RiservazioniOrdini);
                        if(inventory >= 0)
                        {
                            itemToChange.Inventory = inventory.ToString();
                        }
                        else
                        {
                            inventory = 0;
                            itemToChange.Inventory = inventory.ToString();
                        }
                        if (mchkUpdatePrice.Checked) { 
                        itemToChange.Price = x.PrezziLivello5;
                        }
                    }
                    if (itemToChange != null && itemToChange.Inventory != "InStock" && mchkUpdatePrice.Checked && !mchkUpdateQuantity.Checked)
                    {
                        itemToChange.Price = x.PrezziLivello5;
                    }
                    if (itemToChange != null && itemToChange.Inventory == "InStock" && mchkUpdatePrice.Checked)
                    {
                        itemToChange.Price = x.PrezziLivello5;
                    }
                    if (itemToChange != null && x.AttivoInattivo.ToUpper() == "X" && mchkSetInvisibleProductX.Checked)
                    {
                        itemToChange.Visible = "false";
                    }
                }
                if (mchkSetInvisibleProductWithoutSku.Checked) {
                    WixList.Where(a => a.Sku == "").ToList().ForEach(b => b.Visible = "false");
                }

                WixList.Where(x => x.Name == x.Name && x.Name != "" && x.Name != "name" && x.Name.Substring(0, x.Name.Length - 1).Contains("\"")).ToList().ForEach(b => b.Name = b.Name.Replace("\"", "\"\""));
                WixList.Where(x => x.Name == x.Name && x.Name != "" && x.Name != "name" && (x.Name.Contains(",") || x.Name.Substring(0, x.Name.Length - 1).Contains("\""))).ToList().ForEach(b => b.Name = "\"" + b.Name + "\"");

                WixList.Where(x => x.Description == x.Description && x.Description != "" && x.Description != "description" && x.Description.Substring(0, x.Description.Length - 1).Contains("\"")).ToList().ForEach(b => b.Description = b.Description.Replace("\"", "\"\""));
                WixList.Where(x => x.Description == x.Description && x.Description != "description" && x.Description != "").ToList().ForEach(b => b.Description = "\"" + b.Description + "\"");

                WixList.Where(x => x.Collection == x.Collection && x.Collection != "" && x.Collection != "collection" && x.Collection.Substring(0, x.Collection.Length - 1).Contains("\"")).ToList().ForEach(b => b.Collection = b.Collection.Replace("\"", "\"\""));
                WixList.Where(x => x.Collection == x.Collection && x.Collection != "collection" && x.Collection != "" && (x.Collection.Contains(",") || x.Collection.Substring(0, x.Collection.Length - 1).Contains("\""))).ToList().ForEach(b => b.Collection = "\"" + b.Collection + "\"");

                WixList.Where(x => x.Ribbon == x.Ribbon && x.Ribbon != "" && x.Ribbon != "ribbon" && x.Ribbon.Substring(0, x.Ribbon.Length - 1).Contains("\"")).ToList().ForEach(b => b.Ribbon = b.Ribbon.Replace("\"", "\"\""));
                WixList.Where(x => x.Ribbon == x.Ribbon && x.Ribbon != "ribbon" && x.Ribbon != "" && (x.Ribbon.Contains(",") || x.Ribbon.Substring(0, x.Ribbon.Length - 1).Contains("\""))).ToList().ForEach(b => b.Ribbon = "\"" + b.Ribbon + "\"");

                WixList.Where(x => x.AdditionalInfoTitle1 == x.AdditionalInfoTitle1 && x.AdditionalInfoTitle1 != "" && x.AdditionalInfoTitle1 != "additionalInfoTitle1" && x.AdditionalInfoTitle1.Substring(0, x.AdditionalInfoTitle1.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoTitle1 = b.AdditionalInfoTitle1.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoTitle1 == x.AdditionalInfoTitle1 && x.AdditionalInfoTitle1 != "additionalInfoTitle1" && x.AdditionalInfoTitle1 != "" && (x.AdditionalInfoTitle1.Contains(",") || x.AdditionalInfoTitle1.Substring(0, x.AdditionalInfoTitle1.Length - 1).Contains("\""))).ToList().ForEach(b => b.AdditionalInfoTitle1 = "\"" + b.AdditionalInfoTitle1 + "\"");

                WixList.Where(x => x.AdditionalInfoTitle2 == x.AdditionalInfoTitle2 && x.AdditionalInfoTitle2 != "" && x.AdditionalInfoTitle2 != "additionalInfoTitle2" && x.AdditionalInfoTitle2.Substring(0, x.AdditionalInfoTitle2.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoTitle2 = b.AdditionalInfoTitle2.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoTitle2 == x.AdditionalInfoTitle2 && x.AdditionalInfoTitle2 != "additionalInfoTitle2" && x.AdditionalInfoTitle2 != "" && (x.AdditionalInfoTitle2.Contains(",") || x.AdditionalInfoTitle2.Substring(0, x.AdditionalInfoTitle2.Length - 1).Contains("\""))).ToList().ForEach(b => b.AdditionalInfoTitle2 = "\"" + b.AdditionalInfoTitle2 + "\"");

                WixList.Where(x => x.AdditionalInfoTitle3 == x.AdditionalInfoTitle3 && x.AdditionalInfoTitle3 != "" && x.AdditionalInfoTitle3 != "additionalInfoTitle3" && x.AdditionalInfoTitle3.Substring(0, x.AdditionalInfoTitle3.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoTitle3 = b.AdditionalInfoTitle3.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoTitle3 == x.AdditionalInfoTitle3 && x.AdditionalInfoTitle3 != "additionalInfoTitle3" && x.AdditionalInfoTitle3 != "" && (x.AdditionalInfoTitle3.Contains(",") || x.AdditionalInfoTitle3.Substring(0, x.AdditionalInfoTitle3.Length - 1).Contains("\""))).ToList().ForEach(b => b.AdditionalInfoTitle3 = "\"" + b.AdditionalInfoTitle3 + "\"");

                WixList.Where(x => x.AdditionalInfoTitle4 == x.AdditionalInfoTitle4 && x.AdditionalInfoTitle4 != "" && x.AdditionalInfoTitle4 != "additionalInfoTitle4" && x.AdditionalInfoTitle4.Substring(0, x.AdditionalInfoTitle4.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoTitle4 = b.AdditionalInfoTitle4.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoTitle4 == x.AdditionalInfoTitle4 && x.AdditionalInfoTitle4 != "additionalInfoTitle4" && x.AdditionalInfoTitle4 != "" && (x.AdditionalInfoTitle4.Contains(",") || x.AdditionalInfoTitle4.Substring(0, x.AdditionalInfoTitle4.Length - 1).Contains("\""))).ToList().ForEach(b => b.AdditionalInfoTitle4 = "\"" + b.AdditionalInfoTitle4 + "\"");

                WixList.Where(x => x.AdditionalInfoTitle5 == x.AdditionalInfoTitle5 && x.AdditionalInfoTitle5 != "" && x.AdditionalInfoTitle5 != "additionalInfoTitle5" && x.AdditionalInfoTitle5.Substring(0, x.AdditionalInfoTitle5.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoTitle5 = b.AdditionalInfoTitle5.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoTitle5 == x.AdditionalInfoTitle5 && x.AdditionalInfoTitle5 != "additionalInfoTitle5" && x.AdditionalInfoTitle5 != "" && (x.AdditionalInfoTitle5.Contains(",") || x.AdditionalInfoTitle5.Substring(0, x.AdditionalInfoTitle5.Length - 1).Contains("\""))).ToList().ForEach(b => b.AdditionalInfoTitle5 = "\"" + b.AdditionalInfoTitle5 + "\"");

                WixList.Where(x => x.AdditionalInfoTitle6 == x.AdditionalInfoTitle6 && x.AdditionalInfoTitle6 != "" && x.AdditionalInfoTitle6 != "additionalInfoTitle6" && x.AdditionalInfoTitle6.Substring(0, x.AdditionalInfoTitle6.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoTitle6 = b.AdditionalInfoTitle6.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoTitle6 == x.AdditionalInfoTitle6 && x.AdditionalInfoTitle6 != "additionalInfoTitle6" && x.AdditionalInfoTitle6 != "" && (x.AdditionalInfoTitle6.Contains(",") || x.AdditionalInfoTitle6.Substring(0, x.AdditionalInfoTitle6.Length - 1).Contains("\""))).ToList().ForEach(b => b.AdditionalInfoTitle6 = "\"" + b.AdditionalInfoTitle6 + "\"");

                WixList.Where(x => x.ProductOptionName1 == x.ProductOptionName1 && x.ProductOptionName1 != "" && x.ProductOptionName1 != "productOptionName1" && x.ProductOptionName1.Substring(0, x.ProductOptionName1.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionName1 = b.ProductOptionName1.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionName1 == x.ProductOptionName1 && x.ProductOptionName1 != "productOptionName1" && x.ProductOptionName1 != "" && (x.ProductOptionName1.Contains(",") || x.ProductOptionName1.Substring(0, x.ProductOptionName1.Length - 1).Contains("\""))).ToList().ForEach(b => b.ProductOptionName1 = "\"" + b.ProductOptionName1 + "\"");

                WixList.Where(x => x.ProductOptionName2 == x.ProductOptionName2 && x.ProductOptionName2 != "" && x.ProductOptionName2 != "productOptionName2" && x.ProductOptionName2.Substring(0, x.ProductOptionName2.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionName2 = b.ProductOptionName2.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionName2 == x.ProductOptionName2 && x.ProductOptionName2 != "productOptionName2" && x.ProductOptionName2 != "" && (x.ProductOptionName2.Contains(",") || x.ProductOptionName2.Substring(0, x.ProductOptionName2.Length - 1).Contains("\""))).ToList().ForEach(b => b.ProductOptionName2 = "\"" + b.ProductOptionName2 + "\"");

                WixList.Where(x => x.ProductOptionName3 == x.ProductOptionName3 && x.ProductOptionName3 != "" && x.ProductOptionName3 != "productOptionName3" && x.ProductOptionName3.Substring(0, x.ProductOptionName3.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionName3 = b.ProductOptionName3.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionName3 == x.ProductOptionName3 && x.ProductOptionName3 != "productOptionName3" && x.ProductOptionName3 != "" && (x.ProductOptionName3.Contains(",") || x.ProductOptionName3.Substring(0, x.ProductOptionName3.Length - 1).Contains("\""))).ToList().ForEach(b => b.ProductOptionName3 = "\"" + b.ProductOptionName3 + "\"");

                WixList.Where(x => x.ProductOptionName4 == x.ProductOptionName4 && x.ProductOptionName4 != "" && x.ProductOptionName4 != "productOptionName4" && x.ProductOptionName4.Substring(0, x.ProductOptionName4.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionName4 = b.ProductOptionName4.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionName4 == x.ProductOptionName4 && x.ProductOptionName4 != "productOptionName4" && x.ProductOptionName4 != "" && (x.ProductOptionName4.Contains(",") || x.ProductOptionName4.Substring(0, x.ProductOptionName4.Length - 1).Contains("\""))).ToList().ForEach(b => b.ProductOptionName4 = "\"" + b.ProductOptionName4 + "\"");

                WixList.Where(x => x.ProductOptionName5 == x.ProductOptionName5 && x.ProductOptionName5 != "" && x.ProductOptionName5 != "productOptionName5" && x.ProductOptionName5.Substring(0, x.ProductOptionName5.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionName5 = b.ProductOptionName5.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionName5 == x.ProductOptionName5 && x.ProductOptionName5 != "productOptionName5" && x.ProductOptionName5 != "" && (x.ProductOptionName5.Contains(",") || x.ProductOptionName5.Substring(0, x.ProductOptionName5.Length - 1).Contains("\""))).ToList().ForEach(b => b.ProductOptionName5 = "\"" + b.ProductOptionName5 + "\"");

                WixList.Where(x => x.ProductOptionName6 == x.ProductOptionName6 && x.ProductOptionName6 != "" && x.ProductOptionName6 != "productOptionName6" && x.ProductOptionName6.Substring(0, x.ProductOptionName6.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionName6 = b.ProductOptionName6.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionName6 == x.ProductOptionName6 && x.ProductOptionName6 != "productOptionName6" && x.ProductOptionName6 != "" && (x.ProductOptionName6.Contains(",") || x.ProductOptionName6.Substring(0, x.ProductOptionName6.Length - 1).Contains("\""))).ToList().ForEach(b => b.ProductOptionName6 = "\"" + b.ProductOptionName6 + "\"");

                WixList.Where(x => x.ProductOptionDescription1 == x.ProductOptionDescription1 && x.ProductOptionDescription1 != "productOptionDescription1" && x.ProductOptionDescription1 != "" && x.ProductOptionDescription1.Substring(0, x.ProductOptionDescription1.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionDescription1 = b.ProductOptionDescription1.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionDescription1 == x.ProductOptionDescription1 && x.ProductOptionDescription1 != "productOptionDescription1" && x.ProductOptionDescription1 != "").ToList().ForEach(b => b.ProductOptionDescription1 = "\"" + b.ProductOptionDescription1 + "\"");

                WixList.Where(x => x.ProductOptionDescription2 == x.ProductOptionDescription2 && x.ProductOptionDescription2 != "productOptionDescription2" && x.ProductOptionDescription2 != "" && x.ProductOptionDescription2.Substring(0, x.ProductOptionDescription2.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionDescription2 = b.ProductOptionDescription2.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionDescription2 == x.ProductOptionDescription2 && x.ProductOptionDescription2 != "productOptionDescription2" && x.ProductOptionDescription2 != "").ToList().ForEach(b => b.ProductOptionDescription2 = "\"" + b.ProductOptionDescription2 + "\"");

                WixList.Where(x => x.ProductOptionDescription3 == x.ProductOptionDescription3 && x.ProductOptionDescription3 != "productOptionDescription3" && x.ProductOptionDescription3 != "" && x.ProductOptionDescription3.Substring(0, x.ProductOptionDescription3.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionDescription3 = b.ProductOptionDescription3.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionDescription3 == x.ProductOptionDescription3 && x.ProductOptionDescription3 != "productOptionDescription3" && x.ProductOptionDescription3 != "").ToList().ForEach(b => b.ProductOptionDescription3 = "\"" + b.ProductOptionDescription3 + "\"");

                WixList.Where(x => x.ProductOptionDescription4 == x.ProductOptionDescription4 && x.ProductOptionDescription4 != "productOptionDescription4" && x.ProductOptionDescription4 != "" && x.ProductOptionDescription4.Substring(0, x.ProductOptionDescription4.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionDescription4 = b.ProductOptionDescription4.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionDescription4 == x.ProductOptionDescription4 && x.ProductOptionDescription4 != "productOptionDescription4" && x.ProductOptionDescription4 != "").ToList().ForEach(b => b.ProductOptionDescription4 = "\"" + b.ProductOptionDescription4 + "\"");

                WixList.Where(x => x.ProductOptionDescription5 == x.ProductOptionDescription5 && x.ProductOptionDescription5 != "productOptionDescription5" && x.ProductOptionDescription5 != "" && x.ProductOptionDescription5.Substring(0, x.ProductOptionDescription5.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionDescription5 = b.ProductOptionDescription5.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionDescription5 == x.ProductOptionDescription5 && x.ProductOptionDescription5 != "productOptionDescription5" && x.ProductOptionDescription5 != "").ToList().ForEach(b => b.ProductOptionDescription5 = "\"" + b.ProductOptionDescription5 + "\"");

                WixList.Where(x => x.ProductOptionDescription6 == x.ProductOptionDescription6 && x.ProductOptionDescription6 != "productOptionDescription6" && x.ProductOptionDescription6 != "" && x.ProductOptionDescription6.Substring(0, x.ProductOptionDescription6.Length - 1).Contains("\"")).ToList().ForEach(b => b.ProductOptionDescription6 = b.ProductOptionDescription6.Replace("\"", "\"\""));
                WixList.Where(x => x.ProductOptionDescription6 == x.ProductOptionDescription6 && x.ProductOptionDescription6 != "productOptionDescription6" && x.ProductOptionDescription6 != "").ToList().ForEach(b => b.ProductOptionDescription6 = "\"" + b.ProductOptionDescription6 + "\"");

                WixList.Where(x => x.AdditionalInfoDescription1 == x.AdditionalInfoDescription1 && x.AdditionalInfoDescription1 != "" && x.AdditionalInfoDescription1 != "additionalInfoDescription1" && x.AdditionalInfoDescription1.Substring(0, x.AdditionalInfoDescription1.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoDescription1 = b.AdditionalInfoDescription1.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoDescription1 == x.AdditionalInfoDescription1 && x.AdditionalInfoDescription1 != "" && x.AdditionalInfoDescription1 != "additionalInfoDescription1").ToList().ForEach(b => b.AdditionalInfoDescription1 = "\"" + b.AdditionalInfoDescription1 + "\"");

                WixList.Where(x => x.AdditionalInfoDescription2 == x.AdditionalInfoDescription2 && x.AdditionalInfoDescription2 != "" && x.AdditionalInfoDescription2 != "additionalInfoDescription2"  && x.AdditionalInfoDescription2.Substring(0, x.AdditionalInfoDescription2.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoDescription2 = b.AdditionalInfoDescription2.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoDescription2 == x.AdditionalInfoDescription2 && x.AdditionalInfoDescription2 != "" && x.AdditionalInfoDescription2 != "additionalInfoDescription2").ToList().ForEach(b => b.AdditionalInfoDescription2 = "\"" + b.AdditionalInfoDescription2 + "\"");

                WixList.Where(x => x.AdditionalInfoDescription3 == x.AdditionalInfoDescription3 && x.AdditionalInfoDescription3 != "" && x.AdditionalInfoDescription3 != "additionalInfoDescription3"  && x.AdditionalInfoDescription3.Substring(0, x.AdditionalInfoDescription3.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoDescription3 = b.AdditionalInfoDescription3.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoDescription3 == x.AdditionalInfoDescription3 && x.AdditionalInfoDescription3 != "" && x.AdditionalInfoDescription3 != "additionalInfoDescription3").ToList().ForEach(b => b.AdditionalInfoDescription3 = "\"" + b.AdditionalInfoDescription3 + "\"");

                WixList.Where(x => x.AdditionalInfoDescription4 == x.AdditionalInfoDescription4 && x.AdditionalInfoDescription4 != "" && x.AdditionalInfoDescription4 != "additionalInfoDescription4" && x.AdditionalInfoDescription4.Substring(0, x.AdditionalInfoDescription4.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoDescription4 = b.AdditionalInfoDescription4.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoDescription4 == x.AdditionalInfoDescription4 && x.AdditionalInfoDescription4 != "" && x.AdditionalInfoDescription4 != "additionalInfoDescription4").ToList().ForEach(b => b.AdditionalInfoDescription4 = "\"" + b.AdditionalInfoDescription4 + "\"");

                WixList.Where(x => x.AdditionalInfoDescription5 == x.AdditionalInfoDescription5 && x.AdditionalInfoDescription5 != "" && x.AdditionalInfoDescription5 != "additionalInfoDescription5" && x.AdditionalInfoDescription5.Substring(0, x.AdditionalInfoDescription5.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoDescription5 = b.AdditionalInfoDescription5.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoDescription5 == x.AdditionalInfoDescription5 && x.AdditionalInfoDescription5 != "" && x.AdditionalInfoDescription5 != "additionalInfoDescription5").ToList().ForEach(b => b.AdditionalInfoDescription5 = "\"" + b.AdditionalInfoDescription5 + "\"");

                WixList.Where(x => x.AdditionalInfoDescription6 == x.AdditionalInfoDescription6 && x.AdditionalInfoDescription6 != "" && x.AdditionalInfoDescription6 != "additionalInfoDescription6" && x.AdditionalInfoDescription6.Substring(0, x.AdditionalInfoDescription6.Length - 1).Contains("\"")).ToList().ForEach(b => b.AdditionalInfoDescription6 = b.AdditionalInfoDescription6.Replace("\"", "\"\""));
                WixList.Where(x => x.AdditionalInfoDescription6 == x.AdditionalInfoDescription6 && x.AdditionalInfoDescription6 != "" && x.AdditionalInfoDescription6 != "additionalInfoDescription6").ToList().ForEach(b => b.AdditionalInfoDescription6 = "\"" + b.AdditionalInfoDescription6 + "\"");

                Stream myStream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Csv files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)
                    {
                        myStream.Close();
                        using (FileStream fileStream = File.Create(Path.GetFullPath(saveFileDialog.FileName)))
                        {
                            fileStream.Close();
                            ExportCsv(WixList, saveFileDialog.FileName);
                        }
                        MessageBox.Show("File CSV esportato correttamente!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        // Evento Click ricerca riga nel Dgv Wix
        private void mbtnWixFound_Click(object sender, EventArgs e)
        {
            searchWixList = DgvSearch(mtbxWixDgvSearch, dgvWix, mbtnNextWixRow, mbtnPreviousWixRow, mbtnDeleteWixSearch, mbtnWixFound);
            ChangeDgvLbl(dgvWix, mlblWixSelectedRecord, strWixRecords);
        }
        // Evento Click ricerca riga nel Dgv Cassa
        private void mbtnCashDeskFound_Click(object sender, EventArgs e)
        {
            searchCashDeskList = DgvSearch(mtbxCashDeskDgvSearch, dgvCashDesk, mbtnNextCashDeskRow, mbtnPreviousCashDeskRow, mbtnDeleteCashDeskSearch, mbtnCashDeskFound);
            ChangeDgvLbl(dgvCashDesk, mlblCashDeskSelectedRecord, strCashDeskRecords);
        }
        // Evento pressione tasto Enter ricerca riga nel Dgv Wix
        private void mtbxWixDgvSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchWixList = DgvSearch(mtbxWixDgvSearch, dgvWix, mbtnNextWixRow, mbtnPreviousWixRow, mbtnDeleteWixSearch, mbtnWixFound);
            ChangeDgvLbl(dgvWix, mlblWixSelectedRecord, strWixRecords);
        }
        // Evento pressione tasto Enter ricerca riga nel Dgv Cassa
        private void mtbxCashDeskDgvSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchCashDeskList = DgvSearch(mtbxCashDeskDgvSearch, dgvCashDesk, mbtnNextCashDeskRow, mbtnPreviousCashDeskRow, mbtnDeleteCashDeskSearch, mbtnCashDeskFound);
            ChangeDgvLbl(dgvCashDesk, mlblCashDeskSelectedRecord, strCashDeskRecords);
        }
        // Evento Click scorrimento in avanti riga ricercata Dgv Wix
        private void mbtnNextWixRow_Click(object sender, EventArgs e)
        {
            NextRow(searchWixList, mtbxWixDgvSearch, dgvWix, mbtnPreviousWixRow, mbtnNextWixRow);
        }
        // Evento Click scorrimento in avanti riga ricercata Dgv Cassa
        private void mbtnNextCashDeskRow_Click(object sender, EventArgs e)
        {
            NextRow(searchCashDeskList, mtbxCashDeskDgvSearch, dgvCashDesk, mbtnPreviousCashDeskRow, mbtnNextCashDeskRow);
        }
        // Evento Click scorrimento in dietro riga ricercata Dgv Wix
        private void mbtnPreviousWixRow_Click(object sender, EventArgs e)
        {
            PreviousRow(searchWixList, mtbxWixDgvSearch, dgvWix, mbtnPreviousWixRow, mbtnNextWixRow);
        }
        // Evento Click scorrimento in dietro riga ricercata Dgv Cassa
        private void mbtnPreviousCashDeskRow_Click(object sender, EventArgs e)
        {
            PreviousRow(searchCashDeskList, mtbxCashDeskDgvSearch, dgvCashDesk, mbtnPreviousCashDeskRow, mbtnNextCashDeskRow);
        }
        // Evento al completamento del Binding dei dati del Dgv Wix, fa il Set della Label
        private void dgvWix_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           strWixRecords = SetDgvRowCountStr(dgvWix);
        }
        // Evento al completamento del Binding dei dati del Dgv Cassa, fa il Set della Label
        private void dgvCashDesk_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            strCashDeskRecords = SetDgvRowCountStr(dgvCashDesk);
        }
        // Evento al cambio di selezione che modifica la Label in base alla posizione della riga corrente nel Dgv Wix
        private void dgvWix_SelectionChanged(object sender, EventArgs e)
        {
            ChangeDgvLbl(dgvWix, mlblWixSelectedRecord, strWixRecords);
        }
        // Evento al cambio di selezione che modifica la Label in base alla posizione della riga corrente nel Dgv Cassa
        private void dgvCashDesk_SelectionChanged(object sender, EventArgs e)
        {
            ChangeDgvLbl(dgvCashDesk, mlblCashDeskSelectedRecord, strCashDeskRecords);
        }
        // Evento Click Btn Cancella nel caricamento del Csv Wix
        private void mbtnDeleteWixSearch_Click(object sender, EventArgs e)
        {
            DeleteDgvSearch(mtbxWixDgvSearch, dgvWix, mbtnNextWixRow, mbtnPreviousWixRow, mbtnDeleteWixSearch, mbtnWixFound);
            ChangeDgvLbl(dgvWix, mlblWixSelectedRecord, strWixRecords);
        }
        // Evento Click mbtnDeleteCashDeskSearch nel caricamento del Csv Cassa
        private void mbtnDeleteCashDeskSearch_Click(object sender, EventArgs e)
        {
            DeleteDgvSearch(mtbxCashDeskDgvSearch, dgvCashDesk, mbtnNextCashDeskRow, mbtnPreviousCashDeskRow, mbtnDeleteCashDeskSearch, mbtnCashDeskFound);
            ChangeDgvLbl(dgvCashDesk, mlblCashDeskSelectedRecord, strCashDeskRecords);
        }
        // Evento CheckedChanged di mchkUpdateQuantity, disabilita o abilita  mchkConsiderReservations in base allo stato di mchkUpdateQuantity. Lancia anhe il metodo ShowWarningMessage()
        private void mchkUpdateQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!mchkUpdateQuantity.Checked)
            {
                mchkConsiderReservations.Checked = false;
                mchkUpdateQuantity.Checked = false;
                mchkConsiderReservations.Enabled = false;
            }
            else
            {
                mchkConsiderReservations.Enabled = true;
            }
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblOptionsWarningMessage1, mlblOptionsWarningMessage2);
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblLoadFilesWarningMessage1, mlblLoadFilesWarningMessage2);
            ActivateMbtnExportCsv();
        }
        // Evento CheckedChanged di mchkUpdatePrice, lancia il metodo ShowWarningMessage()
        private void mchkUpdatePrice_CheckedChanged(object sender, EventArgs e)
        {
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblOptionsWarningMessage1, mlblOptionsWarningMessage2);
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblLoadFilesWarningMessage1, mlblLoadFilesWarningMessage2);
            ActivateMbtnExportCsv();
        }
        // Evento CheckedChanged di mchkSetInvisibleProductX, lancia il metodo ShowWarningMessage()
        private void mchkSetInvisibleProductX_CheckedChanged(object sender, EventArgs e)
        {
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblOptionsWarningMessage1, mlblOptionsWarningMessage2);
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblLoadFilesWarningMessage1, mlblLoadFilesWarningMessage2);
            ActivateMbtnExportCsv();
        }
        // Evento CheckedChanged di mchkSetInvisibleProductWithoutSku, lancia il metodo ShowWarningMessage()
        private void mchkSetInvisibleProductWithoutSku_CheckedChanged(object sender, EventArgs e)
        {
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblOptionsWarningMessage1, mlblOptionsWarningMessage2);
            ShowWarningMessage(mchkUpdateQuantity, mchkUpdatePrice, mchkSetInvisibleProductX, mchkSetInvisibleProductWithoutSku, mlblLoadFilesWarningMessage1, mlblLoadFilesWarningMessage2);
            ActivateMbtnExportCsv();
        }
        // Evento Caricamento FormMainMenu
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            // Serve e creare ed aggiornare ora
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            // Imposta la trailing icon Search nel mtbxWixDgvSearch e nel mtbxCashDeskDgvSearch
            Image trailingIconSearch = imageListIcon.Images[1];
            mtbxWixDgvSearch.TrailingIcon = trailingIconSearch;
            mtbxCashDeskDgvSearch.TrailingIcon = trailingIconSearch;
            // Imposta data odierna nella mlblDateTime
            mlblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy").ToUpper();
            // Controlla la Properties ColorSchemeName, cambia Stato Radio Button, Logo e fa il Set Colore Orologio
            if (!String.IsNullOrEmpty(Properties.Settings.Default.ColorSchemeName))
            {
                switch (Properties.Settings.Default.ColorSchemeName)
                {
                    case "GreenColorScheme":
                        mrbtnGreen.Checked = true;
                        SetLogo(3);
                        SetColorClock();
                        break;

                    case "RedColorScheme":
                        mrbtnRed.Checked = true;
                        SetLogo(6);
                        SetColorClock();
                        break;

                    case "OrangeColorScheme":
                        mrbtnOrange.Checked = true;
                        SetLogo(4);
                        SetColorClock();
                        break;

                    case "PurpleColorScheme":
                        mrbtnPurple.Checked = true;
                        SetLogo(5);
                        SetColorClock();
                        break;

                    case "BlueColorScheme":
                        mrbtnBlue.Checked = true;
                        SetLogo(1);
                        SetColorClock();
                        break;

                    case "CyanColorScheme":
                        mrbtnCyan.Checked = true;
                        SetLogo(2);
                        SetColorClock();
                        break;

                    case "AmberColorScheme":
                        mrbtnAmber.Checked = true;
                        SetLogo(0);
                        SetColorClock();
                        break;

                    case "PinkColorScheme":
                        mrbtnPink.Checked = true;
                        SetLogo(7);
                        SetColorClock();
                        break;

                    case "GreyColorScheme":
                        mrbtnGrey.Checked = true;
                        SetLogo(8);
                        SetColorClock();
                        break;

                    default:
                        break;
                }
            }
        }
        // Salva le proprietà di Default alla chiusura del FormMainMenu
        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        // Set della Properties ColorSchemeName e Salva
        private static void SetColorSchemeProperties(string strColor)
        {
            Properties.Settings.Default.ColorSchemeName = strColor;
            Properties.Settings.Default.Save();
        }
        // Cambia il ColorScheme e fa il Refresh del Form
        private void ChangeColorScheme(ColorScheme colorScheme)
        {
            materialSkinManager.ColorScheme = colorScheme;
            this.Refresh();
        }
        // Metodo che al cambio del Radio Button fa il Set del Color Scheme, Logo, Properties Color Scheme, Orologio e inserisce il Theme nelle Properties di Default
        private void CheckedChangedMrbtn(ColorScheme colorScheme, int logoIndex, string strColorScheme, MaterialRadioButton mrbtn)
        {
            if (mrbtn.Checked)
            {
                Properties.Settings.Default.ThemeName = materialSkinManager.Theme.ToString();
                ChangeColorScheme(colorScheme);
                SetLogo(logoIndex);
                SetColorSchemeProperties(strColorScheme);
                SetColorClock();
            }
        }
        // Set Tema e Testo
        private void SetThemeAndText(MaterialSkinManager.Themes theme, string mswtThemeText)
        {
            materialSkinManager.Theme = theme;
            mswtTheme.Text = mswtThemeText;
        }
        // Metodo che apre l'OpenFileDialog da C:\\ filtrando i file CSV, inserisce Path del tbx e mostra la trailingIcon
        private void OpenDialogCsvMtbxPath(MaterialTextBox2 mtbx2, int iconIndex, MaterialLabel mlbl, DataGridView dgv)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog()
            {
                Filter = "Csv files (*.csv)|*.csv",
                InitialDirectory = "C://",
                ValidateNames = true
            })
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    mtbx2.Text = openDialog.FileName;
                    csvFilePath = mtbx2.Text;
                    Image trailingIcon = imageListIcon.Images[iconIndex];
                    mtbx2.TrailingIcon = trailingIcon;
                    try
                    {
                        var sr = new StreamReader(new FileStream(openDialog.FileName, FileMode.Open));
                        var csv = new CsvReader(sr, CultureInfo.InvariantCulture);

                        if (mlbl.Name.Equals("lblLoadWixCsv"))
                        {
                            try
                            {
                                wixCsvBindingSource.DataSource = csv.GetRecords<WixCsv>();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Hai inserito il CSV sbagliato!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                sr.Close();
                                DeleteCsvTbxPath(mtbx2, dgv);
                                OpenDialogCsvMtbxPath(mtbx2, iconIndex, mlbl, dgv);
                            }
                            sr.Close();
                        }
                        else if (mlbl.Name.Equals("lblLoadCashDeskCsv"))
                        {
                            string ssr = sr.ReadLine();
                            List<string> listA = new List<string>();
                            if (ssr.Contains(";")) 
                            {
                                ssr = ssr.Replace(";", ",");
                                listA.Add(ssr);
                                while (!sr.EndOfStream)
                                {
                                    var values = "";
                                    var line = "";
                                    line = sr.ReadLine();
                                    line = line.Replace(",", " ");
                                    values = line.Replace(";", ",");
                                    listA.Add(values);
                                }
                                sr.Close();
                            }
                            else if (ssr.Contains(","))
                            {
                                listA.Add(ssr);
                                while (!sr.EndOfStream)
                                {
                                    var values = "";
                                    var line = "";
                                    line = sr.ReadLine();
                                    values = line;
                                    listA.Add(values);
                                }
                                sr.Close();
                            }
                            TextWriter tw = new StreamWriter(openDialog.FileName);
                            foreach (string s in listA)
                            {
                                tw.WriteLine(s);
                            }
                            tw.Close();

                            var sr2 = new StreamReader(new FileStream(openDialog.FileName, FileMode.Open));
                            var csv2 = new CsvReader(sr2, CultureInfo.InvariantCulture);
                            try
                            {
                                wegasCsvBindingSource.DataSource = csv2.GetRecords<WegasCsv>();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Hai inserito il CSV sbagliato!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                sr2.Close();
                                DeleteCsvTbxPath(mtbx2, dgv);
                                OpenDialogCsvMtbxPath(mtbx2, iconIndex, mlbl, dgv);
                            }
                            sr2.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Il file è già aperto in un altro programma, chiudilo!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DeleteCsvTbxPath(mtbx2, dgv);
                        OpenDialogCsvMtbxPath(mtbx2, iconIndex, mlbl, dgv);
                    }
                }
            }
        }
        // Metodo che svuota il tbx, insrisce stringa nulla in filePath e mette null alla trailingIcon
        private void DeleteCsvTbxPath(MaterialTextBox2 mtbx2, DataGridView dgv)
        {
            if (!String.IsNullOrEmpty(mtbx2.Text))
            {
                csvFilePath = "";
                mtbx2.Text = "";
                mtbx2.TrailingIcon = null;
                dgv.Rows.Clear();
                dgv.Refresh();
            }
        }
        // Metodo che inserisce orario nel circularProgressClock
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    circularProgressClock.Text = DateTime.Now.ToString("HH:mm:ss");
                }));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
        }
        // Set del Logo in base all'indice di imageListLogo
        private void SetLogo(int index)
        {
            pbxLogo.Image = imageListLogo.Images[index];
        }
        // Fa il Set del colore del DataGridView
        private void SetDataGridViewColor(DataGridView dgv, Color rdfBackColor, Color rdfForeColor, Color rdfSelBackCol, Color backColor)
        {
            dgv.RowsDefaultCellStyle.BackColor = rdfBackColor;
            dgv.RowsDefaultCellStyle.ForeColor = rdfForeColor;
            dgv.RowsDefaultCellStyle.SelectionBackColor = rdfSelBackCol;
            dgv.BackgroundColor = backColor;
        }
        // Metodo che fa il Set del Colore Orologio in base al ThemeName e al ColorScheme
        private void SetColorClock()
        {
            if (Properties.Settings.Default.ThemeName.Equals("DARK") &&
                !String.IsNullOrEmpty(Properties.Settings.Default.ThemeName) &&
                !String.IsNullOrEmpty(Properties.Settings.Default.ColorSchemeName))
            {
                switch (Properties.Settings.Default.ColorSchemeName)
                {
                    case "GreenColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(46, 125, 50);
                        //circularProgressClock.InnerColor = Color.FromArgb(27, 94, 32);
                        circularProgressClock.OuterColor = Color.FromArgb(27, 94, 32);
                        //circularProgressClock.OuterColor = Color.FromArgb(0, 51, 20);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(27, 94, 32), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(27, 94, 32), Color.FromArgb(29, 32, 37));
                        break;

                    case "RedColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(198, 40, 40);
                        //circularProgressClock.InnerColor = Color.FromArgb(213, 0, 0);
                        circularProgressClock.OuterColor = Color.FromArgb(183, 28, 28);
                        //circularProgressClock.OuterColor = Color.DarkRed;
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(183, 28, 28), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(183, 28, 28), Color.FromArgb(29, 32, 37));
                        break;

                    case "OrangeColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(239, 108, 0);
                        circularProgressClock.OuterColor = Color.FromArgb(230, 81, 0);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(230, 81, 0), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(230, 81, 0), Color.FromArgb(29, 32, 37));
                        break;

                    case "PurpleColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(106, 27, 154);
                        circularProgressClock.OuterColor = Color.FromArgb(74, 20, 140);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(74, 20, 140), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(74, 20, 140), Color.FromArgb(29, 32, 37));
                        break;

                    case "BlueColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(21, 101, 192);
                        circularProgressClock.OuterColor = Color.FromArgb(13, 71, 161);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(13, 71, 161), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(13, 71, 161), Color.FromArgb(29, 32, 37));
                        break;

                    case "CyanColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(0, 131, 143);
                        circularProgressClock.OuterColor = Color.FromArgb(0, 96, 100);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(0, 96, 100), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(0, 96, 100), Color.FromArgb(29, 32, 37));
                        break;

                    case "AmberColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(255, 143, 0);
                        circularProgressClock.OuterColor = Color.FromArgb(255, 111, 0);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(255, 111, 0), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(255, 111, 0), Color.FromArgb(29, 32, 37));
                        break;

                    case "PinkColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(173, 20, 87);
                        circularProgressClock.OuterColor = Color.FromArgb(136, 14, 79);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(136, 14, 79), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(136, 14, 79), Color.FromArgb(29, 32, 37));
                        break;

                    case "GreyColorScheme":
                        circularProgressClock.InnerColor = Color.FromArgb(55, 71, 79);
                        circularProgressClock.OuterColor = Color.FromArgb(38, 50, 56);
                        circularProgressClock.ProgressColor = Color.White;
                        SetDataGridViewColor(dgvWix, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(38, 50, 56), Color.FromArgb(29, 32, 37));
                        SetDataGridViewColor(dgvCashDesk, Color.FromArgb(51, 51, 51), Color.White, Color.FromArgb(38, 50, 56), Color.FromArgb(29, 32, 37));
                        break;

                    default:
                        break;
                }
            }
            else if (Properties.Settings.Default.ThemeName.Equals("LIGHT") &&
                !String.IsNullOrEmpty(Properties.Settings.Default.ThemeName) &&
                !String.IsNullOrEmpty(Properties.Settings.Default.ColorSchemeName))
            {
                switch (Properties.Settings.Default.ColorSchemeName)
                {
                    case "GreenColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(165, 214, 167);
                        circularProgressClock.ProgressColor = Color.FromArgb(27, 94, 32);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(27, 94, 32), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(27, 94, 32), Color.Gray);
                        break;

                    case "RedColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(255, 205, 210);
                        circularProgressClock.ProgressColor = Color.FromArgb(213, 0, 0);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(183, 28, 28), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(183, 28, 28), Color.Gray);
                        break;

                    case "OrangeColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(255, 204, 128);
                        circularProgressClock.ProgressColor = Color.FromArgb(239, 108, 0);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(230, 81, 0), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(230, 81, 0), Color.Gray);
                        break;

                    case "PurpleColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(206, 147, 216);
                        circularProgressClock.ProgressColor = Color.FromArgb(74, 20, 140);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(74, 20, 140), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(74, 20, 140), Color.Gray);
                        break;

                    case "BlueColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(144, 202, 249);
                        circularProgressClock.ProgressColor = Color.FromArgb(13, 71, 161);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(13, 71, 161), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(13, 71, 161), Color.Gray);
                        break;

                    case "CyanColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.Cyan;
                        circularProgressClock.ProgressColor = Color.FromArgb(0, 131, 143);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(0, 96, 100), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(0, 96, 100), Color.Gray);
                        break;

                    case "AmberColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(255, 224, 130);
                        circularProgressClock.ProgressColor = Color.FromArgb(255, 111, 0);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(255, 111, 0), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(255, 111, 0), Color.Gray);
                        break;

                    case "PinkColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(248, 187, 208);
                        circularProgressClock.ProgressColor = Color.FromArgb(173, 20, 87);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(136, 14, 79), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(136, 14, 79), Color.Gray);
                        break;

                    case "GreyColorScheme":
                        circularProgressClock.InnerColor = Color.White;
                        circularProgressClock.OuterColor = Color.FromArgb(207, 216, 220);
                        circularProgressClock.ProgressColor = Color.FromArgb(38, 50, 56);
                        SetDataGridViewColor(dgvWix, Color.White, Color.Black, Color.FromArgb(38, 50, 56), Color.Gray);
                        SetDataGridViewColor(dgvCashDesk, Color.White, Color.Black, Color.FromArgb(38, 50, 56), Color.Gray);
                        break;

                    default:
                        break;
                }
            }
        }
        // Fa il Set di CashDeskList andando a leggere i record in CashDeskCsv
        private void SetCashDeskList()
        {
            try
            {
                if (!String.IsNullOrEmpty(csvFilePathCashDesk))
                {
                    using (var streamReader = new StreamReader(csvFilePathCashDesk))
                    {
                        using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                        {
                            WegasList = csvReader.GetRecords<WegasCsv>().ToList();
                            streamReader.Close();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Application.Restart();
                Environment.Exit(1);
                throw;
            }
        }
        // Fa il Set di WixList andando a leggere i record in WixCsv
        private void SetWixList()
        {
            try
            {
                if (!String.IsNullOrEmpty(csvFilePathWix))
                {
                    using (var streamReader = new StreamReader(csvFilePathWix))
                    {
                        using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                        {
                            WixList = csvReader.GetRecords<WixCsv>().ToList();
                            WixList.Insert(0, columnHeader);
                            streamReader.Close();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Application.Restart();
                Environment.Exit(1);
                throw;
            }

        }
        // Metodo per attivare e disattivare il mbtnExportCsv
        private void ActivateMbtnExportCsv()
        {
            if (!String.IsNullOrEmpty(mtbxCashDeskPath.Text) && !String.IsNullOrEmpty(mtbxWixPath.Text) && (mchkUpdateQuantity.Checked || mchkUpdatePrice.Checked 
                || mchkSetInvisibleProductX.Checked || mchkSetInvisibleProductWithoutSku.Checked))
            {
                mbtnExportCsv.Enabled = true;
            }
            else
            {
                mbtnExportCsv.Enabled = false;
            }
        }
        // Metodo Generico che fa l'export di una List come CSV
        private void ExportCsv<T>(List<T> genericList, string fileName)
        {
            try
            {
                var sb = new StringBuilder();
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var finalPath = Path.Combine(basePath, fileName);
                var header = "";
                var info = typeof(T).GetProperties();
                if (!File.Exists(finalPath))
                {
                    var file = File.Create(finalPath);
                    file.Close();
                    foreach (var prop in typeof(T).GetProperties())
                    {
                        header += prop.Name + ",";
                    }
                    header = header.Substring(0, header.Length - 2);
                    sb.AppendLine(header);
                    TextWriter sw = new StreamWriter(finalPath, true);
                    sw.Write(sb.ToString());
                    sw.Close();
                }
                foreach (var obj in genericList)
                {
                    sb = new StringBuilder();
                    var line = "";
                    foreach (var prop in info)
                    {
                        line += prop.GetValue(obj, null) + ",";
                    }
                    line = line.Substring(0, line.Length - 1);
                    sb.AppendLine(line);
                    TextWriter sw = new StreamWriter(finalPath, true, Encoding.UTF8);
                    sw.Write(sb.ToString());
                    sw.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Application.Restart();
                Environment.Exit(1);
                throw;
            }
        }
        // Metodo per fare la ricerca nei campi del DataGridView
        private List<int> DgvSearch(MaterialTextBox2 mtbx2, DataGridView dgv, MaterialButton mbtnN, MaterialButton mbtnP, MaterialButton mbtnX, MaterialButton mbtnS)
        {
            string searchValue = mtbx2.Text;
            List<int> list = new List<int>();
            indexS = 0;
            if (!String.IsNullOrEmpty(searchValue))
            {
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        row.Selected = false;
                        for (int i = 0; i < dgv.ColumnCount; i++)
                        {
                            if (row.Cells[i].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                            {
                                list.Add(row.Index);
                                dgv.CurrentCell = dgv[0, list.First()];
                                row.Selected = true;
                                break;
                            }
                        }
                    }

                    mbtnP.Enabled = false;
                    mbtnX.Enabled = true;
                    mtbx2.Enabled = false;
                    mbtnS.Enabled = false;

                    if (list.Count > 1)
                        mbtnN.Enabled = true;

                    if (list.First() >= 2)
                    {
                        dgv.FirstDisplayedScrollingRowIndex = list.First() - 2;
                    }
                    else if (list.First() == 1)
                    {
                        dgv.FirstDisplayedScrollingRowIndex = list.First() - 1;
                    }
                    else
                    {
                        dgv.FirstDisplayedScrollingRowIndex = list.First();
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Non hai inserito un campo di ricerca!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        // Metodo che svuota il TextBox Search del DataGridView e lo attiva; disattiva i Button Next, Previous, Delete e attiva il Button Search; deseleziona righe DataGridView; fa il Set della riga corrente alla prima posizione
        private static void DeleteDgvSearch(MaterialTextBox2 mtbx2, DataGridView dgv, MaterialButton mbtnN, MaterialButton mbtnP, MaterialButton mbtnX, MaterialButton mbtnS)
        {
            mtbx2.Text = string.Empty;
            mtbx2.Enabled = true;
            mbtnN.Enabled = false;
            mbtnP.Enabled = false;
            mbtnX.Enabled = false;
            mbtnS.Enabled = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Selected = false;
            }
            dgv.CurrentCell = dgv[0, 0];
        }
        // Metodo che fa il Set del contatore delle righe caricate di un DataGridView 
        private string SetDgvRowCountStr(DataGridView dgv)
        {
            string str;
            str = dgv.RowCount.ToString();
            return str;
        }
        // Metodo che imposta la Label che mostra il Record corrente e il contatore dei Records di un DataGridView
        private void ChangeDgvLbl(DataGridView dgv, MaterialLabel mlbl, string str)
        {
            if (dgv.RowCount > 0)
            {
                mlbl.Text = "Record " + (dgv.CurrentCell.RowIndex + 1).ToString() + " di " + str;
            }
        }
        // Metodo che carica il Csv Wix; abilita e disabilita i Button appropriati; fa il Set della WixList
        private void LoadWixCsv()
        {
            OpenDialogCsvMtbxPath(mtbxWixPath, 0, lblLoadWixCsv, dgvWix);
            if (!String.IsNullOrEmpty(mtbxWixPath.Text))
            {
                csvFilePathWix = csvFilePath;
                SetWixList();
                mbtnWixDelete.Enabled = true;
                mbtnWixLoad.Enabled = false;
                mtbxWixPath.Enabled = false;
                mbtnWixFound.Enabled = true;
                mtbxWixDgvSearch.Enabled = true;
                ActivateMbtnExportCsv();
            }
        }
        // Metodo che carica il Csv Cassa; abilita e disabilita i Button appropriati; fa il Set della WixList
        private void LoadCashDeskCsv()
        {
            OpenDialogCsvMtbxPath(mtbxCashDeskPath, 0, lblLoadCashDeskCsv, dgvCashDesk);
            if (!String.IsNullOrEmpty(mtbxCashDeskPath.Text))
            {
                csvFilePathCashDesk = csvFilePath;
                SetCashDeskList();
                mbtnCashDeskDelete.Enabled = true;
                mbtnCashDeskLoad.Enabled = false;
                mtbxCashDeskPath.Enabled = false;
                mbtnCashDeskFound.Enabled = true;
                mtbxCashDeskDgvSearch.Enabled = true;
                ActivateMbtnExportCsv();
            }
        }
        // Metodo che gestisce la cancellazione del caricamento del CSV Wix
        private void DeleteWixCsv()
        {
            DeleteCsvTbxPath(mtbxWixPath, dgvWix);
            csvFilePathWix = csvFilePath;
            strWixRecords = string.Empty;
            mlblWixSelectedRecord.Text = string.Empty;
            mtbxWixDgvSearch.Text = string.Empty;
            mtbxWixDgvSearch.Enabled = false;
            mbtnWixFound.Enabled = false;
            mbtnNextWixRow.Enabled = false;
            mbtnWixLoad.Enabled = true;
            mbtnWixDelete.Enabled = false;
            ActivateMbtnExportCsv();
        }
        // Metodo che gestisce la cancellazione del caricamento del CSV Cassa
        private void DeleteCashDeskCsv()
        {
            DeleteCsvTbxPath(mtbxCashDeskPath, dgvCashDesk);
            csvFilePathCashDesk = csvFilePath;
            strCashDeskRecords = string.Empty;
            mlblCashDeskSelectedRecord.Text = string.Empty;
            mtbxCashDeskDgvSearch.Text = string.Empty;
            mtbxCashDeskDgvSearch.Enabled = false;
            mbtnCashDeskFound.Enabled = false;
            mbtnNextCashDeskRow.Enabled = false;
            mbtnCashDeskLoad.Enabled = true;
            mbtnCashDeskDelete.Enabled = false;
            ActivateMbtnExportCsv();
        }
        // Metodo per selezionare la prossima riga nel DataGridView in base alla stringa ricercata, abilita e disabilita i Btn e Tbx appropriati 
        private void NextRow(List<int> searchList, MaterialTextBox2 mtbx2DgvSearch, DataGridView dgv, MaterialButton mbtnP, MaterialButton mbtnN)
        {
            if (indexS < searchList.Count && !String.IsNullOrEmpty(mtbx2DgvSearch.Text))
            {
                indexS++;
                dgv.CurrentCell = dgv[0, searchList[indexS]];

                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Selected = false;
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value.ToString().ToLower().Contains(mtbx2DgvSearch.Text.ToLower()))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }

            if (indexS >= 1)
            {
                mbtnP.Enabled = true;
            }
            else
            {
                mbtnP.Enabled = false;
            }

            if (indexS == searchList.Count - 1)
            {
                mbtnN.Enabled = false;
            }
            else
            {
                mbtnN.Enabled = true;
            }
        }
        // Metodo per selezionare la precedente riga nel DataGridView in base alla stringa ricercata, abilita e disabilita i Btn e Tbx appropriati 
        private void PreviousRow(List<int> searchList, MaterialTextBox2 mtbx2DgvSearch, DataGridView dgv, MaterialButton mbtnP, MaterialButton mbtnN)
        {
            if (indexS < searchList.Count && !String.IsNullOrEmpty(mtbx2DgvSearch.Text))
            {
                --indexS;
                dgv.CurrentCell = dgv[0, searchList[indexS]];

                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Selected = false;
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value.ToString().ToLower().Contains(mtbx2DgvSearch.Text.ToLower()))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }

            if (indexS < 1)
            {
                mbtnP.Enabled = false;
            }
            else
            {
                mbtnP.Enabled = true;
            }

            if (indexS == searchList.Count - 1)
            {
                mbtnN.Enabled = false;
            }
            else
            {
                mbtnN.Enabled = true;
            }
        }
        // Metodo che serve per mostrare messaggi diWwarning in base allo stato dei MaterialCheckbox
        private void ShowWarningMessage(MaterialCheckbox mchk1, MaterialCheckbox mchk2, MaterialCheckbox mchk3, MaterialCheckbox mchk4, MaterialLabel mlbl1, MaterialLabel mlbl2)
        {
            if(!mchk1.Checked && !mchk2.Checked && !mchk3.Checked && !mchk4.Checked)
            {
                mlbl1.Visible = true;
                mlbl2.Visible = true;
            } else if (mchk1.Checked || mchk2.Checked || mchk3.Checked || mchk4.Checked)
            {
                mlbl1.Visible = false;
                mlbl2.Visible = false;
            }
        }
        // Metodo che da il Set dello State di un MaterialCheckBox in Checked
        //private void SetCheckBoxStateChecked(MaterialCheckbox mchk)
        //{
        //    mchk.CheckState = CheckState.Checked;
        //}
        //// Metodo che da il Set dello State di un MaterialCheckBox in Unchecked
        //private void SetCheckBoxStateUnchecked(MaterialCheckbox mchk)
        //{
        //    mchk.CheckState = CheckState.Unchecked;
        //}

        //(dgvWix.DataSource as DataTable).DefaultView.RowFilter = "Name = '" + materialTextBox21.Text + "'";
        //dgvWix.Refresh();
    }
}
