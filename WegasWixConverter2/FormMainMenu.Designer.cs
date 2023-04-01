
namespace WegasWixConverter2
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.materialTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.mlblDateTime = new MaterialSkin.Controls.MaterialLabel();
            this.circularProgressClock = new CircularProgressBar.CircularProgressBar();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tabPageCaricaFiles = new System.Windows.Forms.TabPage();
            this.mlblLoadFilesWarningMessage2 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblLoadFilesWarningMessage1 = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnExportCsv = new MaterialSkin.Controls.MaterialButton();
            this.gbxLoadCsv = new System.Windows.Forms.GroupBox();
            this.mbtnWixDelete = new MaterialSkin.Controls.MaterialButton();
            this.lblLoadWixCsv = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnWixLoad = new MaterialSkin.Controls.MaterialButton();
            this.mtbxWixPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.mbtnCashDeskDelete = new MaterialSkin.Controls.MaterialButton();
            this.lblLoadCashDeskCsv = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnCashDeskLoad = new MaterialSkin.Controls.MaterialButton();
            this.mtbxCashDeskPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabPageWegas = new System.Windows.Forms.TabPage();
            this.mbtnDeleteCashDeskSearch = new MaterialSkin.Controls.MaterialButton();
            this.mbtnPreviousCashDeskRow = new MaterialSkin.Controls.MaterialButton();
            this.mbtnNextCashDeskRow = new MaterialSkin.Controls.MaterialButton();
            this.mbtnCashDeskFound = new MaterialSkin.Controls.MaterialButton();
            this.mtbxCashDeskDgvSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.mlblCashDeskSelectedRecord = new MaterialSkin.Controls.MaterialLabel();
            this.dgvCashDesk = new System.Windows.Forms.DataGridView();
            this.numeroArticoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiaveDiRicercaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liberoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAttualeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riservazioniOrdiniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezziLivello5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attivoInattivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wegasCsvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageWix = new System.Windows.Forms.TabPage();
            this.mbtnDeleteWixSearch = new MaterialSkin.Controls.MaterialButton();
            this.mbtnPreviousWixRow = new MaterialSkin.Controls.MaterialButton();
            this.mbtnNextWixRow = new MaterialSkin.Controls.MaterialButton();
            this.mbtnWixFound = new MaterialSkin.Controls.MaterialButton();
            this.mtbxWixDgvSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvWix = new System.Windows.Forms.DataGridView();
            this.handleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribbonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionName1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionType1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionDescription1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionName2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionType2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionDescription2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionName3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionType3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionDescription3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionName4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionType4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionDescription4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionName5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionType5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionDescription5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionName6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionType6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOptionDescription6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoTitle1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDescription1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoTitle2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDescription2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoTitle3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDescription3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoTitle4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDescription4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoTitle5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDescription5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoTitle6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInfoDescription6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customTextField1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customTextCharLimit1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customTextMandatory1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customTextField2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customTextCharLimit2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customTextMandatory2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wixCsvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mlblWixSelectedRecord = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageImpostazioni = new System.Windows.Forms.TabPage();
            this.mlblOptionsWarningMessage2 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblOptionsWarningMessage1 = new MaterialSkin.Controls.MaterialLabel();
            this.gbxBehavior = new System.Windows.Forms.GroupBox();
            this.mchkUpdateQuantity = new MaterialSkin.Controls.MaterialCheckbox();
            this.mchkSetInvisibleProductWithoutSku = new MaterialSkin.Controls.MaterialCheckbox();
            this.mchkSetInvisibleProductX = new MaterialSkin.Controls.MaterialCheckbox();
            this.mchkUpdatePrice = new MaterialSkin.Controls.MaterialCheckbox();
            this.mlblBehavior = new MaterialSkin.Controls.MaterialLabel();
            this.mchkConsiderReservations = new MaterialSkin.Controls.MaterialCheckbox();
            this.gbxTheme = new System.Windows.Forms.GroupBox();
            this.mlblTheme = new MaterialSkin.Controls.MaterialLabel();
            this.mswtTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.gbxColorScheme = new System.Windows.Forms.GroupBox();
            this.mrbtnPink = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnGrey = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnAmber = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnCyan = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnPurple = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.mlblSchemaColori = new MaterialSkin.Controls.MaterialLabel();
            this.mrbtnOrange = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnRed = new MaterialSkin.Controls.MaterialRadioButton();
            this.mrbtnGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.imageListLogo = new System.Windows.Forms.ImageList(this.components);
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.materialTab.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.tabPageCaricaFiles.SuspendLayout();
            this.gbxLoadCsv.SuspendLayout();
            this.tabPageWegas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashDesk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wegasCsvBindingSource)).BeginInit();
            this.tabPageWix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wixCsvBindingSource)).BeginInit();
            this.tabPageImpostazioni.SuspendLayout();
            this.gbxBehavior.SuspendLayout();
            this.gbxTheme.SuspendLayout();
            this.gbxColorScheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTab
            // 
            this.materialTab.Controls.Add(this.tabPageHome);
            this.materialTab.Controls.Add(this.tabPageCaricaFiles);
            this.materialTab.Controls.Add(this.tabPageWegas);
            this.materialTab.Controls.Add(this.tabPageWix);
            this.materialTab.Controls.Add(this.tabPageImpostazioni);
            this.materialTab.Depth = 0;
            this.materialTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTab.ImageList = this.imageListMenu;
            this.materialTab.Location = new System.Drawing.Point(2, 52);
            this.materialTab.Margin = new System.Windows.Forms.Padding(2);
            this.materialTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTab.Multiline = true;
            this.materialTab.Name = "materialTab";
            this.materialTab.SelectedIndex = 0;
            this.materialTab.Size = new System.Drawing.Size(786, 515);
            this.materialTab.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Controls.Add(this.mlblDateTime);
            this.tabPageHome.Controls.Add(this.circularProgressClock);
            this.tabPageHome.Controls.Add(this.pbxLogo);
            this.tabPageHome.ImageKey = "house-solid.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 39);
            this.tabPageHome.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHome.Size = new System.Drawing.Size(778, 472);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            // 
            // mlblDateTime
            // 
            this.mlblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlblDateTime.AutoSize = true;
            this.mlblDateTime.Depth = 0;
            this.mlblDateTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblDateTime.Location = new System.Drawing.Point(16, 446);
            this.mlblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblDateTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblDateTime.Name = "mlblDateTime";
            this.mlblDateTime.Size = new System.Drawing.Size(1, 0);
            this.mlblDateTime.TabIndex = 10;
            // 
            // circularProgressClock
            // 
            this.circularProgressClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.circularProgressClock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressClock.AnimationSpeed = 500;
            this.circularProgressClock.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.circularProgressClock.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressClock.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.circularProgressClock.InnerMargin = 0;
            this.circularProgressClock.InnerWidth = -1;
            this.circularProgressClock.Location = new System.Drawing.Point(697, 398);
            this.circularProgressClock.Margin = new System.Windows.Forms.Padding(2);
            this.circularProgressClock.MarqueeAnimationSpeed = 2000;
            this.circularProgressClock.Name = "circularProgressClock";
            this.circularProgressClock.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.circularProgressClock.OuterMargin = -25;
            this.circularProgressClock.OuterWidth = 26;
            this.circularProgressClock.ProgressColor = System.Drawing.Color.White;
            this.circularProgressClock.ProgressWidth = 4;
            this.circularProgressClock.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.circularProgressClock.Size = new System.Drawing.Size(79, 72);
            this.circularProgressClock.StartAngle = 270;
            this.circularProgressClock.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressClock.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressClock.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressClock.SubscriptText = "";
            this.circularProgressClock.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressClock.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressClock.SuperscriptText = "";
            this.circularProgressClock.TabIndex = 9;
            this.circularProgressClock.Text = "00:00:00";
            this.circularProgressClock.TextMargin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.circularProgressClock.Value = 68;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLogo.Location = new System.Drawing.Point(225, 72);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(376, 324);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // tabPageCaricaFiles
            // 
            this.tabPageCaricaFiles.BackColor = System.Drawing.Color.White;
            this.tabPageCaricaFiles.Controls.Add(this.mlblLoadFilesWarningMessage2);
            this.tabPageCaricaFiles.Controls.Add(this.mlblLoadFilesWarningMessage1);
            this.tabPageCaricaFiles.Controls.Add(this.mbtnExportCsv);
            this.tabPageCaricaFiles.Controls.Add(this.gbxLoadCsv);
            this.tabPageCaricaFiles.ImageKey = "cloud-arrow-down-solid.png";
            this.tabPageCaricaFiles.Location = new System.Drawing.Point(4, 39);
            this.tabPageCaricaFiles.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCaricaFiles.Name = "tabPageCaricaFiles";
            this.tabPageCaricaFiles.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCaricaFiles.Size = new System.Drawing.Size(778, 472);
            this.tabPageCaricaFiles.TabIndex = 1;
            this.tabPageCaricaFiles.Text = "Carica Files";
            this.tabPageCaricaFiles.UseVisualStyleBackColor = true;
            // 
            // mlblLoadFilesWarningMessage2
            // 
            this.mlblLoadFilesWarningMessage2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlblLoadFilesWarningMessage2.AutoSize = true;
            this.mlblLoadFilesWarningMessage2.Depth = 0;
            this.mlblLoadFilesWarningMessage2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblLoadFilesWarningMessage2.Location = new System.Drawing.Point(73, 440);
            this.mlblLoadFilesWarningMessage2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblLoadFilesWarningMessage2.Name = "mlblLoadFilesWarningMessage2";
            this.mlblLoadFilesWarningMessage2.Size = new System.Drawing.Size(283, 19);
            this.mlblLoadFilesWarningMessage2.TabIndex = 3;
            this.mlblLoadFilesWarningMessage2.Text = "Vai su Impostazioni > Comportamento\r\n";
            this.mlblLoadFilesWarningMessage2.Visible = false;
            // 
            // mlblLoadFilesWarningMessage1
            // 
            this.mlblLoadFilesWarningMessage1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlblLoadFilesWarningMessage1.AutoSize = true;
            this.mlblLoadFilesWarningMessage1.Depth = 0;
            this.mlblLoadFilesWarningMessage1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblLoadFilesWarningMessage1.Location = new System.Drawing.Point(73, 422);
            this.mlblLoadFilesWarningMessage1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblLoadFilesWarningMessage1.Name = "mlblLoadFilesWarningMessage1";
            this.mlblLoadFilesWarningMessage1.Size = new System.Drawing.Size(407, 19);
            this.mlblLoadFilesWarningMessage1.TabIndex = 2;
            this.mlblLoadFilesWarningMessage1.Text = "ATTENZIONE: Non è possibile esportare il csv modificato!";
            this.mlblLoadFilesWarningMessage1.Visible = false;
            // 
            // mbtnExportCsv
            // 
            this.mbtnExportCsv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnExportCsv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnExportCsv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnExportCsv.Depth = 0;
            this.mbtnExportCsv.Enabled = false;
            this.mbtnExportCsv.HighEmphasis = true;
            this.mbtnExportCsv.Icon = null;
            this.mbtnExportCsv.Location = new System.Drawing.Point(564, 422);
            this.mbtnExportCsv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnExportCsv.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnExportCsv.Name = "mbtnExportCsv";
            this.mbtnExportCsv.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnExportCsv.Size = new System.Drawing.Size(86, 36);
            this.mbtnExportCsv.TabIndex = 1;
            this.mbtnExportCsv.Text = "Esporta";
            this.mbtnExportCsv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnExportCsv.UseAccentColor = false;
            this.mbtnExportCsv.UseVisualStyleBackColor = true;
            this.mbtnExportCsv.Click += new System.EventHandler(this.mbtnExportCsv_Click);
            // 
            // gbxLoadCsv
            // 
            this.gbxLoadCsv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxLoadCsv.Controls.Add(this.mbtnWixDelete);
            this.gbxLoadCsv.Controls.Add(this.lblLoadWixCsv);
            this.gbxLoadCsv.Controls.Add(this.mbtnWixLoad);
            this.gbxLoadCsv.Controls.Add(this.mtbxWixPath);
            this.gbxLoadCsv.Controls.Add(this.mbtnCashDeskDelete);
            this.gbxLoadCsv.Controls.Add(this.lblLoadCashDeskCsv);
            this.gbxLoadCsv.Controls.Add(this.mbtnCashDeskLoad);
            this.gbxLoadCsv.Controls.Add(this.mtbxCashDeskPath);
            this.gbxLoadCsv.Location = new System.Drawing.Point(73, 53);
            this.gbxLoadCsv.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLoadCsv.Name = "gbxLoadCsv";
            this.gbxLoadCsv.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLoadCsv.Size = new System.Drawing.Size(600, 348);
            this.gbxLoadCsv.TabIndex = 0;
            this.gbxLoadCsv.TabStop = false;
            // 
            // mbtnWixDelete
            // 
            this.mbtnWixDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnWixDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnWixDelete.BackColor = System.Drawing.Color.White;
            this.mbtnWixDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnWixDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnWixDelete.Depth = 0;
            this.mbtnWixDelete.Enabled = false;
            this.mbtnWixDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mbtnWixDelete.HighEmphasis = true;
            this.mbtnWixDelete.Icon = null;
            this.mbtnWixDelete.ImageKey = "(nessuno)";
            this.mbtnWixDelete.Location = new System.Drawing.Point(484, 266);
            this.mbtnWixDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnWixDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnWixDelete.Name = "mbtnWixDelete";
            this.mbtnWixDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnWixDelete.Size = new System.Drawing.Size(95, 36);
            this.mbtnWixDelete.TabIndex = 7;
            this.mbtnWixDelete.Text = "Cancella";
            this.mbtnWixDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnWixDelete.UseAccentColor = false;
            this.mbtnWixDelete.UseVisualStyleBackColor = false;
            this.mbtnWixDelete.Click += new System.EventHandler(this.mbtnWixDelete_Click);
            // 
            // lblLoadWixCsv
            // 
            this.lblLoadWixCsv.AutoSize = true;
            this.lblLoadWixCsv.Depth = 0;
            this.lblLoadWixCsv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoadWixCsv.Location = new System.Drawing.Point(16, 184);
            this.lblLoadWixCsv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoadWixCsv.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoadWixCsv.Name = "lblLoadWixCsv";
            this.lblLoadWixCsv.Size = new System.Drawing.Size(110, 19);
            this.lblLoadWixCsv.TabIndex = 6;
            this.lblLoadWixCsv.Text = "Carica CSV Wix";
            // 
            // mbtnWixLoad
            // 
            this.mbtnWixLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnWixLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnWixLoad.BackColor = System.Drawing.Color.White;
            this.mbtnWixLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnWixLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnWixLoad.Depth = 0;
            this.mbtnWixLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mbtnWixLoad.HighEmphasis = true;
            this.mbtnWixLoad.Icon = null;
            this.mbtnWixLoad.ImageKey = "(nessuno)";
            this.mbtnWixLoad.Location = new System.Drawing.Point(405, 266);
            this.mbtnWixLoad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnWixLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnWixLoad.Name = "mbtnWixLoad";
            this.mbtnWixLoad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnWixLoad.Size = new System.Drawing.Size(73, 36);
            this.mbtnWixLoad.TabIndex = 5;
            this.mbtnWixLoad.Text = "Carica";
            this.mbtnWixLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnWixLoad.UseAccentColor = false;
            this.mbtnWixLoad.UseVisualStyleBackColor = false;
            this.mbtnWixLoad.Click += new System.EventHandler(this.mbtnWixLoad_Click);
            // 
            // mtbxWixPath
            // 
            this.mtbxWixPath.AnimateReadOnly = true;
            this.mtbxWixPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbxWixPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbxWixPath.Depth = 0;
            this.mtbxWixPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbxWixPath.HideSelection = true;
            this.mtbxWixPath.LeadingIcon = null;
            this.mtbxWixPath.Location = new System.Drawing.Point(18, 210);
            this.mtbxWixPath.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxWixPath.MaxLength = 32767;
            this.mtbxWixPath.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxWixPath.Name = "mtbxWixPath";
            this.mtbxWixPath.PasswordChar = '\0';
            this.mtbxWixPath.PrefixSuffixText = null;
            this.mtbxWixPath.ReadOnly = true;
            this.mtbxWixPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbxWixPath.SelectedText = "";
            this.mtbxWixPath.SelectionLength = 0;
            this.mtbxWixPath.SelectionStart = 0;
            this.mtbxWixPath.ShortcutsEnabled = true;
            this.mtbxWixPath.Size = new System.Drawing.Size(563, 48);
            this.mtbxWixPath.TabIndex = 4;
            this.mtbxWixPath.TabStop = false;
            this.mtbxWixPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxWixPath.TrailingIcon = null;
            this.mtbxWixPath.UseSystemPasswordChar = false;
            this.mtbxWixPath.DoubleClick += new System.EventHandler(this.mtbxWixPath_DoubleClick);
            // 
            // mbtnCashDeskDelete
            // 
            this.mbtnCashDeskDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnCashDeskDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCashDeskDelete.BackColor = System.Drawing.Color.White;
            this.mbtnCashDeskDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnCashDeskDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCashDeskDelete.Depth = 0;
            this.mbtnCashDeskDelete.Enabled = false;
            this.mbtnCashDeskDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mbtnCashDeskDelete.HighEmphasis = true;
            this.mbtnCashDeskDelete.Icon = null;
            this.mbtnCashDeskDelete.ImageKey = "(nessuno)";
            this.mbtnCashDeskDelete.Location = new System.Drawing.Point(484, 134);
            this.mbtnCashDeskDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnCashDeskDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCashDeskDelete.Name = "mbtnCashDeskDelete";
            this.mbtnCashDeskDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCashDeskDelete.Size = new System.Drawing.Size(95, 36);
            this.mbtnCashDeskDelete.TabIndex = 3;
            this.mbtnCashDeskDelete.Text = "Cancella";
            this.mbtnCashDeskDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCashDeskDelete.UseAccentColor = false;
            this.mbtnCashDeskDelete.UseVisualStyleBackColor = false;
            this.mbtnCashDeskDelete.Click += new System.EventHandler(this.mbtnCashDeskDelete_Click);
            // 
            // lblLoadCashDeskCsv
            // 
            this.lblLoadCashDeskCsv.AutoSize = true;
            this.lblLoadCashDeskCsv.Depth = 0;
            this.lblLoadCashDeskCsv.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoadCashDeskCsv.Location = new System.Drawing.Point(16, 52);
            this.lblLoadCashDeskCsv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoadCashDeskCsv.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoadCashDeskCsv.Name = "lblLoadCashDeskCsv";
            this.lblLoadCashDeskCsv.Size = new System.Drawing.Size(128, 19);
            this.lblLoadCashDeskCsv.TabIndex = 2;
            this.lblLoadCashDeskCsv.Text = "Carica CSV Cassa";
            // 
            // mbtnCashDeskLoad
            // 
            this.mbtnCashDeskLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnCashDeskLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCashDeskLoad.BackColor = System.Drawing.Color.White;
            this.mbtnCashDeskLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnCashDeskLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCashDeskLoad.Depth = 0;
            this.mbtnCashDeskLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mbtnCashDeskLoad.HighEmphasis = true;
            this.mbtnCashDeskLoad.Icon = null;
            this.mbtnCashDeskLoad.ImageKey = "(nessuno)";
            this.mbtnCashDeskLoad.Location = new System.Drawing.Point(405, 134);
            this.mbtnCashDeskLoad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnCashDeskLoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCashDeskLoad.Name = "mbtnCashDeskLoad";
            this.mbtnCashDeskLoad.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCashDeskLoad.Size = new System.Drawing.Size(73, 36);
            this.mbtnCashDeskLoad.TabIndex = 1;
            this.mbtnCashDeskLoad.Text = "Carica";
            this.mbtnCashDeskLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCashDeskLoad.UseAccentColor = false;
            this.mbtnCashDeskLoad.UseVisualStyleBackColor = false;
            this.mbtnCashDeskLoad.Click += new System.EventHandler(this.mbtnCashDeskLoad_Click);
            // 
            // mtbxCashDeskPath
            // 
            this.mtbxCashDeskPath.AnimateReadOnly = true;
            this.mtbxCashDeskPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbxCashDeskPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbxCashDeskPath.Depth = 0;
            this.mtbxCashDeskPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbxCashDeskPath.HideSelection = true;
            this.mtbxCashDeskPath.LeadingIcon = null;
            this.mtbxCashDeskPath.Location = new System.Drawing.Point(18, 78);
            this.mtbxCashDeskPath.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxCashDeskPath.MaxLength = 32767;
            this.mtbxCashDeskPath.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxCashDeskPath.Name = "mtbxCashDeskPath";
            this.mtbxCashDeskPath.PasswordChar = '\0';
            this.mtbxCashDeskPath.PrefixSuffixText = null;
            this.mtbxCashDeskPath.ReadOnly = true;
            this.mtbxCashDeskPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbxCashDeskPath.SelectedText = "";
            this.mtbxCashDeskPath.SelectionLength = 0;
            this.mtbxCashDeskPath.SelectionStart = 0;
            this.mtbxCashDeskPath.ShortcutsEnabled = true;
            this.mtbxCashDeskPath.Size = new System.Drawing.Size(563, 48);
            this.mtbxCashDeskPath.TabIndex = 0;
            this.mtbxCashDeskPath.TabStop = false;
            this.mtbxCashDeskPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxCashDeskPath.TrailingIcon = null;
            this.mtbxCashDeskPath.UseSystemPasswordChar = false;
            this.mtbxCashDeskPath.DoubleClick += new System.EventHandler(this.mtbxCashDeskPath_DoubleClick);
            // 
            // tabPageWegas
            // 
            this.tabPageWegas.BackColor = System.Drawing.Color.White;
            this.tabPageWegas.Controls.Add(this.mbtnDeleteCashDeskSearch);
            this.tabPageWegas.Controls.Add(this.mbtnPreviousCashDeskRow);
            this.tabPageWegas.Controls.Add(this.mbtnNextCashDeskRow);
            this.tabPageWegas.Controls.Add(this.mbtnCashDeskFound);
            this.tabPageWegas.Controls.Add(this.mtbxCashDeskDgvSearch);
            this.tabPageWegas.Controls.Add(this.mlblCashDeskSelectedRecord);
            this.tabPageWegas.Controls.Add(this.dgvCashDesk);
            this.tabPageWegas.ImageKey = "cash-register-solid.png";
            this.tabPageWegas.Location = new System.Drawing.Point(4, 39);
            this.tabPageWegas.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageWegas.Name = "tabPageWegas";
            this.tabPageWegas.Size = new System.Drawing.Size(778, 472);
            this.tabPageWegas.TabIndex = 2;
            this.tabPageWegas.Text = "Wegas";
            // 
            // mbtnDeleteCashDeskSearch
            // 
            this.mbtnDeleteCashDeskSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnDeleteCashDeskSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDeleteCashDeskSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnDeleteCashDeskSearch.Depth = 0;
            this.mbtnDeleteCashDeskSearch.Enabled = false;
            this.mbtnDeleteCashDeskSearch.HighEmphasis = true;
            this.mbtnDeleteCashDeskSearch.Icon = null;
            this.mbtnDeleteCashDeskSearch.Location = new System.Drawing.Point(260, 430);
            this.mbtnDeleteCashDeskSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnDeleteCashDeskSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDeleteCashDeskSearch.Name = "mbtnDeleteCashDeskSearch";
            this.mbtnDeleteCashDeskSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnDeleteCashDeskSearch.Size = new System.Drawing.Size(64, 36);
            this.mbtnDeleteCashDeskSearch.TabIndex = 12;
            this.mbtnDeleteCashDeskSearch.Text = "X";
            this.mbtnDeleteCashDeskSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnDeleteCashDeskSearch.UseAccentColor = false;
            this.mbtnDeleteCashDeskSearch.UseVisualStyleBackColor = true;
            this.mbtnDeleteCashDeskSearch.Click += new System.EventHandler(this.mbtnDeleteCashDeskSearch_Click);
            // 
            // mbtnPreviousCashDeskRow
            // 
            this.mbtnPreviousCashDeskRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnPreviousCashDeskRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPreviousCashDeskRow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPreviousCashDeskRow.Depth = 0;
            this.mbtnPreviousCashDeskRow.Enabled = false;
            this.mbtnPreviousCashDeskRow.HighEmphasis = true;
            this.mbtnPreviousCashDeskRow.Icon = null;
            this.mbtnPreviousCashDeskRow.Location = new System.Drawing.Point(331, 430);
            this.mbtnPreviousCashDeskRow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnPreviousCashDeskRow.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPreviousCashDeskRow.Name = "mbtnPreviousCashDeskRow";
            this.mbtnPreviousCashDeskRow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPreviousCashDeskRow.Size = new System.Drawing.Size(64, 36);
            this.mbtnPreviousCashDeskRow.TabIndex = 11;
            this.mbtnPreviousCashDeskRow.Text = "<";
            this.mbtnPreviousCashDeskRow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPreviousCashDeskRow.UseAccentColor = false;
            this.mbtnPreviousCashDeskRow.UseVisualStyleBackColor = true;
            this.mbtnPreviousCashDeskRow.Click += new System.EventHandler(this.mbtnPreviousCashDeskRow_Click);
            // 
            // mbtnNextCashDeskRow
            // 
            this.mbtnNextCashDeskRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnNextCashDeskRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnNextCashDeskRow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnNextCashDeskRow.Depth = 0;
            this.mbtnNextCashDeskRow.Enabled = false;
            this.mbtnNextCashDeskRow.HighEmphasis = true;
            this.mbtnNextCashDeskRow.Icon = null;
            this.mbtnNextCashDeskRow.Location = new System.Drawing.Point(407, 430);
            this.mbtnNextCashDeskRow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnNextCashDeskRow.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnNextCashDeskRow.Name = "mbtnNextCashDeskRow";
            this.mbtnNextCashDeskRow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnNextCashDeskRow.Size = new System.Drawing.Size(64, 36);
            this.mbtnNextCashDeskRow.TabIndex = 10;
            this.mbtnNextCashDeskRow.Text = ">";
            this.mbtnNextCashDeskRow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnNextCashDeskRow.UseAccentColor = false;
            this.mbtnNextCashDeskRow.UseVisualStyleBackColor = true;
            this.mbtnNextCashDeskRow.Click += new System.EventHandler(this.mbtnNextCashDeskRow_Click);
            // 
            // mbtnCashDeskFound
            // 
            this.mbtnCashDeskFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnCashDeskFound.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnCashDeskFound.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnCashDeskFound.Depth = 0;
            this.mbtnCashDeskFound.Enabled = false;
            this.mbtnCashDeskFound.HighEmphasis = true;
            this.mbtnCashDeskFound.Icon = null;
            this.mbtnCashDeskFound.Location = new System.Drawing.Point(692, 432);
            this.mbtnCashDeskFound.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnCashDeskFound.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnCashDeskFound.Name = "mbtnCashDeskFound";
            this.mbtnCashDeskFound.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnCashDeskFound.Size = new System.Drawing.Size(69, 36);
            this.mbtnCashDeskFound.TabIndex = 8;
            this.mbtnCashDeskFound.Text = "Trova";
            this.mbtnCashDeskFound.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnCashDeskFound.UseAccentColor = false;
            this.mbtnCashDeskFound.UseVisualStyleBackColor = true;
            this.mbtnCashDeskFound.Click += new System.EventHandler(this.mbtnCashDeskFound_Click);
            // 
            // mtbxCashDeskDgvSearch
            // 
            this.mtbxCashDeskDgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbxCashDeskDgvSearch.AnimateReadOnly = false;
            this.mtbxCashDeskDgvSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbxCashDeskDgvSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbxCashDeskDgvSearch.Depth = 0;
            this.mtbxCashDeskDgvSearch.Enabled = false;
            this.mtbxCashDeskDgvSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbxCashDeskDgvSearch.HideSelection = true;
            this.mtbxCashDeskDgvSearch.LeadingIcon = null;
            this.mtbxCashDeskDgvSearch.Location = new System.Drawing.Point(477, 427);
            this.mtbxCashDeskDgvSearch.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxCashDeskDgvSearch.MaxLength = 32767;
            this.mtbxCashDeskDgvSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxCashDeskDgvSearch.Name = "mtbxCashDeskDgvSearch";
            this.mtbxCashDeskDgvSearch.PasswordChar = '\0';
            this.mtbxCashDeskDgvSearch.PrefixSuffixText = null;
            this.mtbxCashDeskDgvSearch.ReadOnly = false;
            this.mtbxCashDeskDgvSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbxCashDeskDgvSearch.SelectedText = "";
            this.mtbxCashDeskDgvSearch.SelectionLength = 0;
            this.mtbxCashDeskDgvSearch.SelectionStart = 0;
            this.mtbxCashDeskDgvSearch.ShortcutsEnabled = true;
            this.mtbxCashDeskDgvSearch.Size = new System.Drawing.Size(206, 48);
            this.mtbxCashDeskDgvSearch.TabIndex = 7;
            this.mtbxCashDeskDgvSearch.TabStop = false;
            this.mtbxCashDeskDgvSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxCashDeskDgvSearch.TrailingIcon = null;
            this.mtbxCashDeskDgvSearch.UseSystemPasswordChar = false;
            this.mtbxCashDeskDgvSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxCashDeskDgvSearch_KeyDown);
            // 
            // mlblCashDeskSelectedRecord
            // 
            this.mlblCashDeskSelectedRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlblCashDeskSelectedRecord.AutoSize = true;
            this.mlblCashDeskSelectedRecord.Depth = 0;
            this.mlblCashDeskSelectedRecord.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblCashDeskSelectedRecord.Location = new System.Drawing.Point(13, 445);
            this.mlblCashDeskSelectedRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblCashDeskSelectedRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblCashDeskSelectedRecord.Name = "mlblCashDeskSelectedRecord";
            this.mlblCashDeskSelectedRecord.Size = new System.Drawing.Size(1, 0);
            this.mlblCashDeskSelectedRecord.TabIndex = 9;
            // 
            // dgvCashDesk
            // 
            this.dgvCashDesk.AllowUserToAddRows = false;
            this.dgvCashDesk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCashDesk.AutoGenerateColumns = false;
            this.dgvCashDesk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.dgvCashDesk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCashDesk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashDesk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroArticoloDataGridViewTextBoxColumn,
            this.chiaveDiRicercaDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.denominazioneDataGridViewTextBoxColumn,
            this.liberoDataGridViewTextBoxColumn,
            this.annataDataGridViewTextBoxColumn,
            this.gradazioneDataGridViewTextBoxColumn,
            this.stockAttualeDataGridViewTextBoxColumn,
            this.riservazioniOrdiniDataGridViewTextBoxColumn,
            this.prezziLivello5DataGridViewTextBoxColumn,
            this.attivoInattivoDataGridViewTextBoxColumn});
            this.dgvCashDesk.DataSource = this.wegasCsvBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashDesk.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCashDesk.Location = new System.Drawing.Point(0, 0);
            this.dgvCashDesk.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCashDesk.Name = "dgvCashDesk";
            this.dgvCashDesk.RowHeadersWidth = 51;
            this.dgvCashDesk.RowTemplate.Height = 24;
            this.dgvCashDesk.Size = new System.Drawing.Size(780, 413);
            this.dgvCashDesk.TabIndex = 0;
            this.dgvCashDesk.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCashDesk_DataBindingComplete);
            this.dgvCashDesk.SelectionChanged += new System.EventHandler(this.dgvCashDesk_SelectionChanged);
            // 
            // numeroArticoloDataGridViewTextBoxColumn
            // 
            this.numeroArticoloDataGridViewTextBoxColumn.DataPropertyName = "NumeroArticolo";
            this.numeroArticoloDataGridViewTextBoxColumn.HeaderText = "NumeroArticolo";
            this.numeroArticoloDataGridViewTextBoxColumn.Name = "numeroArticoloDataGridViewTextBoxColumn";
            this.numeroArticoloDataGridViewTextBoxColumn.Width = 150;
            // 
            // chiaveDiRicercaDataGridViewTextBoxColumn
            // 
            this.chiaveDiRicercaDataGridViewTextBoxColumn.DataPropertyName = "ChiaveDiRicerca";
            this.chiaveDiRicercaDataGridViewTextBoxColumn.HeaderText = "ChiaveDiRicerca";
            this.chiaveDiRicercaDataGridViewTextBoxColumn.Name = "chiaveDiRicercaDataGridViewTextBoxColumn";
            this.chiaveDiRicercaDataGridViewTextBoxColumn.Width = 150;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.Width = 150;
            // 
            // denominazioneDataGridViewTextBoxColumn
            // 
            this.denominazioneDataGridViewTextBoxColumn.DataPropertyName = "Denominazione";
            this.denominazioneDataGridViewTextBoxColumn.HeaderText = "Denominazione";
            this.denominazioneDataGridViewTextBoxColumn.Name = "denominazioneDataGridViewTextBoxColumn";
            this.denominazioneDataGridViewTextBoxColumn.Width = 150;
            // 
            // liberoDataGridViewTextBoxColumn
            // 
            this.liberoDataGridViewTextBoxColumn.DataPropertyName = "Libero";
            this.liberoDataGridViewTextBoxColumn.HeaderText = "Libero";
            this.liberoDataGridViewTextBoxColumn.Name = "liberoDataGridViewTextBoxColumn";
            this.liberoDataGridViewTextBoxColumn.Width = 150;
            // 
            // annataDataGridViewTextBoxColumn
            // 
            this.annataDataGridViewTextBoxColumn.DataPropertyName = "Annata";
            this.annataDataGridViewTextBoxColumn.HeaderText = "Annata";
            this.annataDataGridViewTextBoxColumn.Name = "annataDataGridViewTextBoxColumn";
            this.annataDataGridViewTextBoxColumn.Width = 150;
            // 
            // gradazioneDataGridViewTextBoxColumn
            // 
            this.gradazioneDataGridViewTextBoxColumn.DataPropertyName = "Gradazione";
            this.gradazioneDataGridViewTextBoxColumn.HeaderText = "Gradazione";
            this.gradazioneDataGridViewTextBoxColumn.Name = "gradazioneDataGridViewTextBoxColumn";
            this.gradazioneDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockAttualeDataGridViewTextBoxColumn
            // 
            this.stockAttualeDataGridViewTextBoxColumn.DataPropertyName = "StockAttuale";
            this.stockAttualeDataGridViewTextBoxColumn.HeaderText = "StockAttuale";
            this.stockAttualeDataGridViewTextBoxColumn.Name = "stockAttualeDataGridViewTextBoxColumn";
            this.stockAttualeDataGridViewTextBoxColumn.Width = 150;
            // 
            // riservazioniOrdiniDataGridViewTextBoxColumn
            // 
            this.riservazioniOrdiniDataGridViewTextBoxColumn.DataPropertyName = "RiservazioniOrdini";
            this.riservazioniOrdiniDataGridViewTextBoxColumn.HeaderText = "RiservazioniOrdini";
            this.riservazioniOrdiniDataGridViewTextBoxColumn.Name = "riservazioniOrdiniDataGridViewTextBoxColumn";
            this.riservazioniOrdiniDataGridViewTextBoxColumn.Width = 150;
            // 
            // prezziLivello5DataGridViewTextBoxColumn
            // 
            this.prezziLivello5DataGridViewTextBoxColumn.DataPropertyName = "PrezziLivello5";
            this.prezziLivello5DataGridViewTextBoxColumn.HeaderText = "PrezziLivello5";
            this.prezziLivello5DataGridViewTextBoxColumn.Name = "prezziLivello5DataGridViewTextBoxColumn";
            this.prezziLivello5DataGridViewTextBoxColumn.Width = 150;
            // 
            // attivoInattivoDataGridViewTextBoxColumn
            // 
            this.attivoInattivoDataGridViewTextBoxColumn.DataPropertyName = "AttivoInattivo";
            this.attivoInattivoDataGridViewTextBoxColumn.HeaderText = "AttivoInattivo";
            this.attivoInattivoDataGridViewTextBoxColumn.Name = "attivoInattivoDataGridViewTextBoxColumn";
            this.attivoInattivoDataGridViewTextBoxColumn.Width = 150;
            // 
            // wegasCsvBindingSource
            // 
            this.wegasCsvBindingSource.DataSource = typeof(WegasWixConverter2.WegasCsv);
            // 
            // tabPageWix
            // 
            this.tabPageWix.BackColor = System.Drawing.Color.White;
            this.tabPageWix.Controls.Add(this.mbtnDeleteWixSearch);
            this.tabPageWix.Controls.Add(this.mbtnPreviousWixRow);
            this.tabPageWix.Controls.Add(this.mbtnNextWixRow);
            this.tabPageWix.Controls.Add(this.mbtnWixFound);
            this.tabPageWix.Controls.Add(this.mtbxWixDgvSearch);
            this.tabPageWix.Controls.Add(this.dgvWix);
            this.tabPageWix.Controls.Add(this.mlblWixSelectedRecord);
            this.tabPageWix.ImageKey = "wix-brands.png";
            this.tabPageWix.Location = new System.Drawing.Point(4, 39);
            this.tabPageWix.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageWix.Name = "tabPageWix";
            this.tabPageWix.Size = new System.Drawing.Size(778, 472);
            this.tabPageWix.TabIndex = 3;
            this.tabPageWix.Text = "Wix";
            // 
            // mbtnDeleteWixSearch
            // 
            this.mbtnDeleteWixSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnDeleteWixSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDeleteWixSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnDeleteWixSearch.Depth = 0;
            this.mbtnDeleteWixSearch.Enabled = false;
            this.mbtnDeleteWixSearch.HighEmphasis = true;
            this.mbtnDeleteWixSearch.Icon = null;
            this.mbtnDeleteWixSearch.Location = new System.Drawing.Point(260, 430);
            this.mbtnDeleteWixSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnDeleteWixSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDeleteWixSearch.Name = "mbtnDeleteWixSearch";
            this.mbtnDeleteWixSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnDeleteWixSearch.Size = new System.Drawing.Size(64, 36);
            this.mbtnDeleteWixSearch.TabIndex = 7;
            this.mbtnDeleteWixSearch.Text = "X";
            this.mbtnDeleteWixSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnDeleteWixSearch.UseAccentColor = false;
            this.mbtnDeleteWixSearch.UseVisualStyleBackColor = true;
            this.mbtnDeleteWixSearch.Click += new System.EventHandler(this.mbtnDeleteWixSearch_Click);
            // 
            // mbtnPreviousWixRow
            // 
            this.mbtnPreviousWixRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnPreviousWixRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPreviousWixRow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPreviousWixRow.Depth = 0;
            this.mbtnPreviousWixRow.Enabled = false;
            this.mbtnPreviousWixRow.HighEmphasis = true;
            this.mbtnPreviousWixRow.Icon = null;
            this.mbtnPreviousWixRow.Location = new System.Drawing.Point(331, 430);
            this.mbtnPreviousWixRow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnPreviousWixRow.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPreviousWixRow.Name = "mbtnPreviousWixRow";
            this.mbtnPreviousWixRow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPreviousWixRow.Size = new System.Drawing.Size(64, 36);
            this.mbtnPreviousWixRow.TabIndex = 6;
            this.mbtnPreviousWixRow.Text = "<";
            this.mbtnPreviousWixRow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPreviousWixRow.UseAccentColor = false;
            this.mbtnPreviousWixRow.UseVisualStyleBackColor = true;
            this.mbtnPreviousWixRow.Click += new System.EventHandler(this.mbtnPreviousWixRow_Click);
            // 
            // mbtnNextWixRow
            // 
            this.mbtnNextWixRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnNextWixRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnNextWixRow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnNextWixRow.Depth = 0;
            this.mbtnNextWixRow.Enabled = false;
            this.mbtnNextWixRow.HighEmphasis = true;
            this.mbtnNextWixRow.Icon = null;
            this.mbtnNextWixRow.Location = new System.Drawing.Point(407, 430);
            this.mbtnNextWixRow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnNextWixRow.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnNextWixRow.Name = "mbtnNextWixRow";
            this.mbtnNextWixRow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnNextWixRow.Size = new System.Drawing.Size(64, 36);
            this.mbtnNextWixRow.TabIndex = 5;
            this.mbtnNextWixRow.Text = ">";
            this.mbtnNextWixRow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnNextWixRow.UseAccentColor = false;
            this.mbtnNextWixRow.UseVisualStyleBackColor = true;
            this.mbtnNextWixRow.Click += new System.EventHandler(this.mbtnNextWixRow_Click);
            // 
            // mbtnWixFound
            // 
            this.mbtnWixFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnWixFound.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnWixFound.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnWixFound.Depth = 0;
            this.mbtnWixFound.Enabled = false;
            this.mbtnWixFound.HighEmphasis = true;
            this.mbtnWixFound.Icon = null;
            this.mbtnWixFound.Location = new System.Drawing.Point(692, 432);
            this.mbtnWixFound.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mbtnWixFound.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnWixFound.Name = "mbtnWixFound";
            this.mbtnWixFound.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnWixFound.Size = new System.Drawing.Size(69, 36);
            this.mbtnWixFound.TabIndex = 3;
            this.mbtnWixFound.Text = "Trova";
            this.mbtnWixFound.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnWixFound.UseAccentColor = false;
            this.mbtnWixFound.UseVisualStyleBackColor = true;
            this.mbtnWixFound.Click += new System.EventHandler(this.mbtnWixFound_Click);
            // 
            // mtbxWixDgvSearch
            // 
            this.mtbxWixDgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbxWixDgvSearch.AnimateReadOnly = false;
            this.mtbxWixDgvSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbxWixDgvSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtbxWixDgvSearch.Depth = 0;
            this.mtbxWixDgvSearch.Enabled = false;
            this.mtbxWixDgvSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbxWixDgvSearch.HideSelection = true;
            this.mtbxWixDgvSearch.LeadingIcon = null;
            this.mtbxWixDgvSearch.Location = new System.Drawing.Point(477, 427);
            this.mtbxWixDgvSearch.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxWixDgvSearch.MaxLength = 32767;
            this.mtbxWixDgvSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxWixDgvSearch.Name = "mtbxWixDgvSearch";
            this.mtbxWixDgvSearch.PasswordChar = '\0';
            this.mtbxWixDgvSearch.PrefixSuffixText = null;
            this.mtbxWixDgvSearch.ReadOnly = false;
            this.mtbxWixDgvSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbxWixDgvSearch.SelectedText = "";
            this.mtbxWixDgvSearch.SelectionLength = 0;
            this.mtbxWixDgvSearch.SelectionStart = 0;
            this.mtbxWixDgvSearch.ShortcutsEnabled = true;
            this.mtbxWixDgvSearch.Size = new System.Drawing.Size(206, 48);
            this.mtbxWixDgvSearch.TabIndex = 2;
            this.mtbxWixDgvSearch.TabStop = false;
            this.mtbxWixDgvSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbxWixDgvSearch.TrailingIcon = null;
            this.mtbxWixDgvSearch.UseSystemPasswordChar = false;
            this.mtbxWixDgvSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxWixDgvSearch_KeyDown);
            // 
            // dgvWix
            // 
            this.dgvWix.AllowUserToAddRows = false;
            this.dgvWix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWix.AutoGenerateColumns = false;
            this.dgvWix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.dgvWix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.handleIdDataGridViewTextBoxColumn,
            this.fieldTypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.productImageUrlDataGridViewTextBoxColumn,
            this.collectionDataGridViewTextBoxColumn,
            this.skuDataGridViewTextBoxColumn,
            this.ribbonDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.surchargeDataGridViewTextBoxColumn,
            this.visibleDataGridViewTextBoxColumn,
            this.discountModeDataGridViewTextBoxColumn,
            this.discountValueDataGridViewTextBoxColumn,
            this.inventoryDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.productOptionName1DataGridViewTextBoxColumn,
            this.productOptionType1DataGridViewTextBoxColumn,
            this.productOptionDescription1DataGridViewTextBoxColumn,
            this.productOptionName2DataGridViewTextBoxColumn,
            this.productOptionType2DataGridViewTextBoxColumn,
            this.productOptionDescription2DataGridViewTextBoxColumn,
            this.productOptionName3DataGridViewTextBoxColumn,
            this.productOptionType3DataGridViewTextBoxColumn,
            this.productOptionDescription3DataGridViewTextBoxColumn,
            this.productOptionName4DataGridViewTextBoxColumn,
            this.productOptionType4DataGridViewTextBoxColumn,
            this.productOptionDescription4DataGridViewTextBoxColumn,
            this.productOptionName5DataGridViewTextBoxColumn,
            this.productOptionType5DataGridViewTextBoxColumn,
            this.productOptionDescription5DataGridViewTextBoxColumn,
            this.productOptionName6DataGridViewTextBoxColumn,
            this.productOptionType6DataGridViewTextBoxColumn,
            this.productOptionDescription6DataGridViewTextBoxColumn,
            this.additionalInfoTitle1DataGridViewTextBoxColumn,
            this.additionalInfoDescription1DataGridViewTextBoxColumn,
            this.additionalInfoTitle2DataGridViewTextBoxColumn,
            this.additionalInfoDescription2DataGridViewTextBoxColumn,
            this.additionalInfoTitle3DataGridViewTextBoxColumn,
            this.additionalInfoDescription3DataGridViewTextBoxColumn,
            this.additionalInfoTitle4DataGridViewTextBoxColumn,
            this.additionalInfoDescription4DataGridViewTextBoxColumn,
            this.additionalInfoTitle5DataGridViewTextBoxColumn,
            this.additionalInfoDescription5DataGridViewTextBoxColumn,
            this.additionalInfoTitle6DataGridViewTextBoxColumn,
            this.additionalInfoDescription6DataGridViewTextBoxColumn,
            this.customTextField1DataGridViewTextBoxColumn,
            this.customTextCharLimit1DataGridViewTextBoxColumn,
            this.customTextMandatory1DataGridViewTextBoxColumn,
            this.customTextField2DataGridViewTextBoxColumn,
            this.customTextCharLimit2DataGridViewTextBoxColumn,
            this.customTextMandatory2DataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn});
            this.dgvWix.DataSource = this.wixCsvBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWix.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWix.Location = new System.Drawing.Point(0, 0);
            this.dgvWix.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWix.Name = "dgvWix";
            this.dgvWix.RowHeadersWidth = 51;
            this.dgvWix.RowTemplate.Height = 24;
            this.dgvWix.Size = new System.Drawing.Size(780, 413);
            this.dgvWix.TabIndex = 0;
            this.dgvWix.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvWix_DataBindingComplete);
            this.dgvWix.SelectionChanged += new System.EventHandler(this.dgvWix_SelectionChanged);
            // 
            // handleIdDataGridViewTextBoxColumn
            // 
            this.handleIdDataGridViewTextBoxColumn.DataPropertyName = "HandleId";
            this.handleIdDataGridViewTextBoxColumn.HeaderText = "HandleId";
            this.handleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.handleIdDataGridViewTextBoxColumn.Name = "handleIdDataGridViewTextBoxColumn";
            this.handleIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // fieldTypeDataGridViewTextBoxColumn
            // 
            this.fieldTypeDataGridViewTextBoxColumn.DataPropertyName = "FieldType";
            this.fieldTypeDataGridViewTextBoxColumn.HeaderText = "FieldType";
            this.fieldTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fieldTypeDataGridViewTextBoxColumn.Name = "fieldTypeDataGridViewTextBoxColumn";
            this.fieldTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // productImageUrlDataGridViewTextBoxColumn
            // 
            this.productImageUrlDataGridViewTextBoxColumn.DataPropertyName = "ProductImageUrl";
            this.productImageUrlDataGridViewTextBoxColumn.HeaderText = "ProductImageUrl";
            this.productImageUrlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productImageUrlDataGridViewTextBoxColumn.Name = "productImageUrlDataGridViewTextBoxColumn";
            this.productImageUrlDataGridViewTextBoxColumn.Width = 200;
            // 
            // collectionDataGridViewTextBoxColumn
            // 
            this.collectionDataGridViewTextBoxColumn.DataPropertyName = "Collection";
            this.collectionDataGridViewTextBoxColumn.HeaderText = "Collection";
            this.collectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collectionDataGridViewTextBoxColumn.Name = "collectionDataGridViewTextBoxColumn";
            this.collectionDataGridViewTextBoxColumn.Width = 150;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "Sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "Sku";
            this.skuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.Width = 150;
            // 
            // ribbonDataGridViewTextBoxColumn
            // 
            this.ribbonDataGridViewTextBoxColumn.DataPropertyName = "Ribbon";
            this.ribbonDataGridViewTextBoxColumn.HeaderText = "Ribbon";
            this.ribbonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ribbonDataGridViewTextBoxColumn.Name = "ribbonDataGridViewTextBoxColumn";
            this.ribbonDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // surchargeDataGridViewTextBoxColumn
            // 
            this.surchargeDataGridViewTextBoxColumn.DataPropertyName = "Surcharge";
            this.surchargeDataGridViewTextBoxColumn.HeaderText = "Surcharge";
            this.surchargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surchargeDataGridViewTextBoxColumn.Name = "surchargeDataGridViewTextBoxColumn";
            this.surchargeDataGridViewTextBoxColumn.Width = 150;
            // 
            // visibleDataGridViewTextBoxColumn
            // 
            this.visibleDataGridViewTextBoxColumn.DataPropertyName = "Visible";
            this.visibleDataGridViewTextBoxColumn.HeaderText = "Visible";
            this.visibleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visibleDataGridViewTextBoxColumn.Name = "visibleDataGridViewTextBoxColumn";
            this.visibleDataGridViewTextBoxColumn.Width = 150;
            // 
            // discountModeDataGridViewTextBoxColumn
            // 
            this.discountModeDataGridViewTextBoxColumn.DataPropertyName = "DiscountMode";
            this.discountModeDataGridViewTextBoxColumn.HeaderText = "DiscountMode";
            this.discountModeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountModeDataGridViewTextBoxColumn.Name = "discountModeDataGridViewTextBoxColumn";
            this.discountModeDataGridViewTextBoxColumn.Width = 150;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            this.discountValueDataGridViewTextBoxColumn.DataPropertyName = "DiscountValue";
            this.discountValueDataGridViewTextBoxColumn.HeaderText = "DiscountValue";
            this.discountValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            this.discountValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // inventoryDataGridViewTextBoxColumn
            // 
            this.inventoryDataGridViewTextBoxColumn.DataPropertyName = "Inventory";
            this.inventoryDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.inventoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inventoryDataGridViewTextBoxColumn.Name = "inventoryDataGridViewTextBoxColumn";
            this.inventoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 150;
            // 
            // productOptionName1DataGridViewTextBoxColumn
            // 
            this.productOptionName1DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionName1";
            this.productOptionName1DataGridViewTextBoxColumn.HeaderText = "ProductOptionName1";
            this.productOptionName1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionName1DataGridViewTextBoxColumn.Name = "productOptionName1DataGridViewTextBoxColumn";
            this.productOptionName1DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionType1DataGridViewTextBoxColumn
            // 
            this.productOptionType1DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionType1";
            this.productOptionType1DataGridViewTextBoxColumn.HeaderText = "ProductOptionType1";
            this.productOptionType1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionType1DataGridViewTextBoxColumn.Name = "productOptionType1DataGridViewTextBoxColumn";
            this.productOptionType1DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionDescription1DataGridViewTextBoxColumn
            // 
            this.productOptionDescription1DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionDescription1";
            this.productOptionDescription1DataGridViewTextBoxColumn.HeaderText = "ProductOptionDescription1";
            this.productOptionDescription1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionDescription1DataGridViewTextBoxColumn.Name = "productOptionDescription1DataGridViewTextBoxColumn";
            this.productOptionDescription1DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionName2DataGridViewTextBoxColumn
            // 
            this.productOptionName2DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionName2";
            this.productOptionName2DataGridViewTextBoxColumn.HeaderText = "ProductOptionName2";
            this.productOptionName2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionName2DataGridViewTextBoxColumn.Name = "productOptionName2DataGridViewTextBoxColumn";
            this.productOptionName2DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionType2DataGridViewTextBoxColumn
            // 
            this.productOptionType2DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionType2";
            this.productOptionType2DataGridViewTextBoxColumn.HeaderText = "ProductOptionType2";
            this.productOptionType2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionType2DataGridViewTextBoxColumn.Name = "productOptionType2DataGridViewTextBoxColumn";
            this.productOptionType2DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionDescription2DataGridViewTextBoxColumn
            // 
            this.productOptionDescription2DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionDescription2";
            this.productOptionDescription2DataGridViewTextBoxColumn.HeaderText = "ProductOptionDescription2";
            this.productOptionDescription2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionDescription2DataGridViewTextBoxColumn.Name = "productOptionDescription2DataGridViewTextBoxColumn";
            this.productOptionDescription2DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionName3DataGridViewTextBoxColumn
            // 
            this.productOptionName3DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionName3";
            this.productOptionName3DataGridViewTextBoxColumn.HeaderText = "ProductOptionName3";
            this.productOptionName3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionName3DataGridViewTextBoxColumn.Name = "productOptionName3DataGridViewTextBoxColumn";
            this.productOptionName3DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionType3DataGridViewTextBoxColumn
            // 
            this.productOptionType3DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionType3";
            this.productOptionType3DataGridViewTextBoxColumn.HeaderText = "ProductOptionType3";
            this.productOptionType3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionType3DataGridViewTextBoxColumn.Name = "productOptionType3DataGridViewTextBoxColumn";
            this.productOptionType3DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionDescription3DataGridViewTextBoxColumn
            // 
            this.productOptionDescription3DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionDescription3";
            this.productOptionDescription3DataGridViewTextBoxColumn.HeaderText = "ProductOptionDescription3";
            this.productOptionDescription3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionDescription3DataGridViewTextBoxColumn.Name = "productOptionDescription3DataGridViewTextBoxColumn";
            this.productOptionDescription3DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionName4DataGridViewTextBoxColumn
            // 
            this.productOptionName4DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionName4";
            this.productOptionName4DataGridViewTextBoxColumn.HeaderText = "ProductOptionName4";
            this.productOptionName4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionName4DataGridViewTextBoxColumn.Name = "productOptionName4DataGridViewTextBoxColumn";
            this.productOptionName4DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionType4DataGridViewTextBoxColumn
            // 
            this.productOptionType4DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionType4";
            this.productOptionType4DataGridViewTextBoxColumn.HeaderText = "ProductOptionType4";
            this.productOptionType4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionType4DataGridViewTextBoxColumn.Name = "productOptionType4DataGridViewTextBoxColumn";
            this.productOptionType4DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionDescription4DataGridViewTextBoxColumn
            // 
            this.productOptionDescription4DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionDescription4";
            this.productOptionDescription4DataGridViewTextBoxColumn.HeaderText = "ProductOptionDescription4";
            this.productOptionDescription4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionDescription4DataGridViewTextBoxColumn.Name = "productOptionDescription4DataGridViewTextBoxColumn";
            this.productOptionDescription4DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionName5DataGridViewTextBoxColumn
            // 
            this.productOptionName5DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionName5";
            this.productOptionName5DataGridViewTextBoxColumn.HeaderText = "ProductOptionName5";
            this.productOptionName5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionName5DataGridViewTextBoxColumn.Name = "productOptionName5DataGridViewTextBoxColumn";
            this.productOptionName5DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionType5DataGridViewTextBoxColumn
            // 
            this.productOptionType5DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionType5";
            this.productOptionType5DataGridViewTextBoxColumn.HeaderText = "ProductOptionType5";
            this.productOptionType5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionType5DataGridViewTextBoxColumn.Name = "productOptionType5DataGridViewTextBoxColumn";
            this.productOptionType5DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionDescription5DataGridViewTextBoxColumn
            // 
            this.productOptionDescription5DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionDescription5";
            this.productOptionDescription5DataGridViewTextBoxColumn.HeaderText = "ProductOptionDescription5";
            this.productOptionDescription5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionDescription5DataGridViewTextBoxColumn.Name = "productOptionDescription5DataGridViewTextBoxColumn";
            this.productOptionDescription5DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionName6DataGridViewTextBoxColumn
            // 
            this.productOptionName6DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionName6";
            this.productOptionName6DataGridViewTextBoxColumn.HeaderText = "ProductOptionName6";
            this.productOptionName6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionName6DataGridViewTextBoxColumn.Name = "productOptionName6DataGridViewTextBoxColumn";
            this.productOptionName6DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionType6DataGridViewTextBoxColumn
            // 
            this.productOptionType6DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionType6";
            this.productOptionType6DataGridViewTextBoxColumn.HeaderText = "ProductOptionType6";
            this.productOptionType6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionType6DataGridViewTextBoxColumn.Name = "productOptionType6DataGridViewTextBoxColumn";
            this.productOptionType6DataGridViewTextBoxColumn.Width = 200;
            // 
            // productOptionDescription6DataGridViewTextBoxColumn
            // 
            this.productOptionDescription6DataGridViewTextBoxColumn.DataPropertyName = "ProductOptionDescription6";
            this.productOptionDescription6DataGridViewTextBoxColumn.HeaderText = "ProductOptionDescription6";
            this.productOptionDescription6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productOptionDescription6DataGridViewTextBoxColumn.Name = "productOptionDescription6DataGridViewTextBoxColumn";
            this.productOptionDescription6DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoTitle1DataGridViewTextBoxColumn
            // 
            this.additionalInfoTitle1DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoTitle1";
            this.additionalInfoTitle1DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoTitle1";
            this.additionalInfoTitle1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoTitle1DataGridViewTextBoxColumn.Name = "additionalInfoTitle1DataGridViewTextBoxColumn";
            this.additionalInfoTitle1DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoDescription1DataGridViewTextBoxColumn
            // 
            this.additionalInfoDescription1DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoDescription1";
            this.additionalInfoDescription1DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoDescription1";
            this.additionalInfoDescription1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDescription1DataGridViewTextBoxColumn.Name = "additionalInfoDescription1DataGridViewTextBoxColumn";
            this.additionalInfoDescription1DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoTitle2DataGridViewTextBoxColumn
            // 
            this.additionalInfoTitle2DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoTitle2";
            this.additionalInfoTitle2DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoTitle2";
            this.additionalInfoTitle2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoTitle2DataGridViewTextBoxColumn.Name = "additionalInfoTitle2DataGridViewTextBoxColumn";
            this.additionalInfoTitle2DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoDescription2DataGridViewTextBoxColumn
            // 
            this.additionalInfoDescription2DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoDescription2";
            this.additionalInfoDescription2DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoDescription2";
            this.additionalInfoDescription2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDescription2DataGridViewTextBoxColumn.Name = "additionalInfoDescription2DataGridViewTextBoxColumn";
            this.additionalInfoDescription2DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoTitle3DataGridViewTextBoxColumn
            // 
            this.additionalInfoTitle3DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoTitle3";
            this.additionalInfoTitle3DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoTitle3";
            this.additionalInfoTitle3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoTitle3DataGridViewTextBoxColumn.Name = "additionalInfoTitle3DataGridViewTextBoxColumn";
            this.additionalInfoTitle3DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoDescription3DataGridViewTextBoxColumn
            // 
            this.additionalInfoDescription3DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoDescription3";
            this.additionalInfoDescription3DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoDescription3";
            this.additionalInfoDescription3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDescription3DataGridViewTextBoxColumn.Name = "additionalInfoDescription3DataGridViewTextBoxColumn";
            this.additionalInfoDescription3DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoTitle4DataGridViewTextBoxColumn
            // 
            this.additionalInfoTitle4DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoTitle4";
            this.additionalInfoTitle4DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoTitle4";
            this.additionalInfoTitle4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoTitle4DataGridViewTextBoxColumn.Name = "additionalInfoTitle4DataGridViewTextBoxColumn";
            this.additionalInfoTitle4DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoDescription4DataGridViewTextBoxColumn
            // 
            this.additionalInfoDescription4DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoDescription4";
            this.additionalInfoDescription4DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoDescription4";
            this.additionalInfoDescription4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDescription4DataGridViewTextBoxColumn.Name = "additionalInfoDescription4DataGridViewTextBoxColumn";
            this.additionalInfoDescription4DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoTitle5DataGridViewTextBoxColumn
            // 
            this.additionalInfoTitle5DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoTitle5";
            this.additionalInfoTitle5DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoTitle5";
            this.additionalInfoTitle5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoTitle5DataGridViewTextBoxColumn.Name = "additionalInfoTitle5DataGridViewTextBoxColumn";
            this.additionalInfoTitle5DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoDescription5DataGridViewTextBoxColumn
            // 
            this.additionalInfoDescription5DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoDescription5";
            this.additionalInfoDescription5DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoDescription5";
            this.additionalInfoDescription5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDescription5DataGridViewTextBoxColumn.Name = "additionalInfoDescription5DataGridViewTextBoxColumn";
            this.additionalInfoDescription5DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoTitle6DataGridViewTextBoxColumn
            // 
            this.additionalInfoTitle6DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoTitle6";
            this.additionalInfoTitle6DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoTitle6";
            this.additionalInfoTitle6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoTitle6DataGridViewTextBoxColumn.Name = "additionalInfoTitle6DataGridViewTextBoxColumn";
            this.additionalInfoTitle6DataGridViewTextBoxColumn.Width = 200;
            // 
            // additionalInfoDescription6DataGridViewTextBoxColumn
            // 
            this.additionalInfoDescription6DataGridViewTextBoxColumn.DataPropertyName = "AdditionalInfoDescription6";
            this.additionalInfoDescription6DataGridViewTextBoxColumn.HeaderText = "AdditionalInfoDescription6";
            this.additionalInfoDescription6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalInfoDescription6DataGridViewTextBoxColumn.Name = "additionalInfoDescription6DataGridViewTextBoxColumn";
            this.additionalInfoDescription6DataGridViewTextBoxColumn.Width = 200;
            // 
            // customTextField1DataGridViewTextBoxColumn
            // 
            this.customTextField1DataGridViewTextBoxColumn.DataPropertyName = "CustomTextField1";
            this.customTextField1DataGridViewTextBoxColumn.HeaderText = "CustomTextField1";
            this.customTextField1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customTextField1DataGridViewTextBoxColumn.Name = "customTextField1DataGridViewTextBoxColumn";
            this.customTextField1DataGridViewTextBoxColumn.Width = 200;
            // 
            // customTextCharLimit1DataGridViewTextBoxColumn
            // 
            this.customTextCharLimit1DataGridViewTextBoxColumn.DataPropertyName = "CustomTextCharLimit1";
            this.customTextCharLimit1DataGridViewTextBoxColumn.HeaderText = "CustomTextCharLimit1";
            this.customTextCharLimit1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customTextCharLimit1DataGridViewTextBoxColumn.Name = "customTextCharLimit1DataGridViewTextBoxColumn";
            this.customTextCharLimit1DataGridViewTextBoxColumn.Width = 200;
            // 
            // customTextMandatory1DataGridViewTextBoxColumn
            // 
            this.customTextMandatory1DataGridViewTextBoxColumn.DataPropertyName = "CustomTextMandatory1";
            this.customTextMandatory1DataGridViewTextBoxColumn.HeaderText = "CustomTextMandatory1";
            this.customTextMandatory1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customTextMandatory1DataGridViewTextBoxColumn.Name = "customTextMandatory1DataGridViewTextBoxColumn";
            this.customTextMandatory1DataGridViewTextBoxColumn.Width = 200;
            // 
            // customTextField2DataGridViewTextBoxColumn
            // 
            this.customTextField2DataGridViewTextBoxColumn.DataPropertyName = "CustomTextField2";
            this.customTextField2DataGridViewTextBoxColumn.HeaderText = "CustomTextField2";
            this.customTextField2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customTextField2DataGridViewTextBoxColumn.Name = "customTextField2DataGridViewTextBoxColumn";
            this.customTextField2DataGridViewTextBoxColumn.Width = 200;
            // 
            // customTextCharLimit2DataGridViewTextBoxColumn
            // 
            this.customTextCharLimit2DataGridViewTextBoxColumn.DataPropertyName = "CustomTextCharLimit2";
            this.customTextCharLimit2DataGridViewTextBoxColumn.HeaderText = "CustomTextCharLimit2";
            this.customTextCharLimit2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customTextCharLimit2DataGridViewTextBoxColumn.Name = "customTextCharLimit2DataGridViewTextBoxColumn";
            this.customTextCharLimit2DataGridViewTextBoxColumn.Width = 200;
            // 
            // customTextMandatory2DataGridViewTextBoxColumn
            // 
            this.customTextMandatory2DataGridViewTextBoxColumn.DataPropertyName = "CustomTextMandatory2";
            this.customTextMandatory2DataGridViewTextBoxColumn.HeaderText = "CustomTextMandatory2";
            this.customTextMandatory2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customTextMandatory2DataGridViewTextBoxColumn.Name = "customTextMandatory2DataGridViewTextBoxColumn";
            this.customTextMandatory2DataGridViewTextBoxColumn.Width = 200;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 150;
            // 
            // wixCsvBindingSource
            // 
            this.wixCsvBindingSource.DataSource = typeof(WegasWixConverter2.WixCsv);
            // 
            // mlblWixSelectedRecord
            // 
            this.mlblWixSelectedRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mlblWixSelectedRecord.AutoSize = true;
            this.mlblWixSelectedRecord.Depth = 0;
            this.mlblWixSelectedRecord.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblWixSelectedRecord.Location = new System.Drawing.Point(13, 445);
            this.mlblWixSelectedRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblWixSelectedRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblWixSelectedRecord.Name = "mlblWixSelectedRecord";
            this.mlblWixSelectedRecord.Size = new System.Drawing.Size(1, 0);
            this.mlblWixSelectedRecord.TabIndex = 4;
            // 
            // tabPageImpostazioni
            // 
            this.tabPageImpostazioni.Controls.Add(this.mlblOptionsWarningMessage2);
            this.tabPageImpostazioni.Controls.Add(this.mlblOptionsWarningMessage1);
            this.tabPageImpostazioni.Controls.Add(this.gbxBehavior);
            this.tabPageImpostazioni.Controls.Add(this.gbxTheme);
            this.tabPageImpostazioni.Controls.Add(this.gbxColorScheme);
            this.tabPageImpostazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageImpostazioni.ImageKey = "screwdriver-wrench-solid.png";
            this.tabPageImpostazioni.Location = new System.Drawing.Point(4, 39);
            this.tabPageImpostazioni.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageImpostazioni.Name = "tabPageImpostazioni";
            this.tabPageImpostazioni.Size = new System.Drawing.Size(778, 472);
            this.tabPageImpostazioni.TabIndex = 6;
            this.tabPageImpostazioni.Text = "Impostazioni";
            this.tabPageImpostazioni.UseVisualStyleBackColor = true;
            // 
            // mlblOptionsWarningMessage2
            // 
            this.mlblOptionsWarningMessage2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlblOptionsWarningMessage2.AutoSize = true;
            this.mlblOptionsWarningMessage2.Depth = 0;
            this.mlblOptionsWarningMessage2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblOptionsWarningMessage2.Location = new System.Drawing.Point(66, 428);
            this.mlblOptionsWarningMessage2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblOptionsWarningMessage2.Name = "mlblOptionsWarningMessage2";
            this.mlblOptionsWarningMessage2.Size = new System.Drawing.Size(304, 19);
            this.mlblOptionsWarningMessage2.TabIndex = 10;
            this.mlblOptionsWarningMessage2.Text = "Non è possibile esportare il csv modificato!";
            this.mlblOptionsWarningMessage2.Visible = false;
            // 
            // mlblOptionsWarningMessage1
            // 
            this.mlblOptionsWarningMessage1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlblOptionsWarningMessage1.AutoSize = true;
            this.mlblOptionsWarningMessage1.Depth = 0;
            this.mlblOptionsWarningMessage1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblOptionsWarningMessage1.Location = new System.Drawing.Point(66, 409);
            this.mlblOptionsWarningMessage1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblOptionsWarningMessage1.Name = "mlblOptionsWarningMessage1";
            this.mlblOptionsWarningMessage1.Size = new System.Drawing.Size(596, 19);
            this.mlblOptionsWarningMessage1.TabIndex = 9;
            this.mlblOptionsWarningMessage1.Text = "ATTENZIONE: Non hai selezionato nessun visto in Impostazioni > Comportamento.\r\n";
            this.mlblOptionsWarningMessage1.Visible = false;
            // 
            // gbxBehavior
            // 
            this.gbxBehavior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxBehavior.Controls.Add(this.mchkUpdateQuantity);
            this.gbxBehavior.Controls.Add(this.mchkSetInvisibleProductWithoutSku);
            this.gbxBehavior.Controls.Add(this.mchkSetInvisibleProductX);
            this.gbxBehavior.Controls.Add(this.mchkUpdatePrice);
            this.gbxBehavior.Controls.Add(this.mlblBehavior);
            this.gbxBehavior.Controls.Add(this.mchkConsiderReservations);
            this.gbxBehavior.Location = new System.Drawing.Point(66, 48);
            this.gbxBehavior.Name = "gbxBehavior";
            this.gbxBehavior.Size = new System.Drawing.Size(300, 237);
            this.gbxBehavior.TabIndex = 8;
            this.gbxBehavior.TabStop = false;
            // 
            // mchkUpdateQuantity
            // 
            this.mchkUpdateQuantity.AutoSize = true;
            this.mchkUpdateQuantity.Checked = global::WegasWixConverter2.Properties.Settings.Default.MchkUpdateQuantityState;
            this.mchkUpdateQuantity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkUpdateQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WegasWixConverter2.Properties.Settings.Default, "MchkUpdateQuantityState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mchkUpdateQuantity.Depth = 0;
            this.mchkUpdateQuantity.Location = new System.Drawing.Point(13, 39);
            this.mchkUpdateQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.mchkUpdateQuantity.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkUpdateQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkUpdateQuantity.Name = "mchkUpdateQuantity";
            this.mchkUpdateQuantity.ReadOnly = false;
            this.mchkUpdateQuantity.Ripple = true;
            this.mchkUpdateQuantity.Size = new System.Drawing.Size(162, 37);
            this.mchkUpdateQuantity.TabIndex = 5;
            this.mchkUpdateQuantity.Text = "Aggiorna quantità";
            this.mchkUpdateQuantity.UseVisualStyleBackColor = true;
            this.mchkUpdateQuantity.CheckedChanged += new System.EventHandler(this.mchkUpdateQuantity_CheckedChanged);
            // 
            // mchkSetInvisibleProductWithoutSku
            // 
            this.mchkSetInvisibleProductWithoutSku.AutoSize = true;
            this.mchkSetInvisibleProductWithoutSku.Checked = global::WegasWixConverter2.Properties.Settings.Default.MchkSetInvisibleProductWithoutSkuState;
            this.mchkSetInvisibleProductWithoutSku.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WegasWixConverter2.Properties.Settings.Default, "MchkSetInvisibleProductWithoutSkuState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mchkSetInvisibleProductWithoutSku.Depth = 0;
            this.mchkSetInvisibleProductWithoutSku.Location = new System.Drawing.Point(13, 187);
            this.mchkSetInvisibleProductWithoutSku.Margin = new System.Windows.Forms.Padding(0);
            this.mchkSetInvisibleProductWithoutSku.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkSetInvisibleProductWithoutSku.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkSetInvisibleProductWithoutSku.Name = "mchkSetInvisibleProductWithoutSku";
            this.mchkSetInvisibleProductWithoutSku.ReadOnly = false;
            this.mchkSetInvisibleProductWithoutSku.Ripple = true;
            this.mchkSetInvisibleProductWithoutSku.Size = new System.Drawing.Size(273, 37);
            this.mchkSetInvisibleProductWithoutSku.TabIndex = 4;
            this.mchkSetInvisibleProductWithoutSku.Text = "Rendi invisibili prodotti senza Sku";
            this.mchkSetInvisibleProductWithoutSku.UseVisualStyleBackColor = true;
            this.mchkSetInvisibleProductWithoutSku.CheckedChanged += new System.EventHandler(this.mchkSetInvisibleProductWithoutSku_CheckedChanged);
            // 
            // mchkSetInvisibleProductX
            // 
            this.mchkSetInvisibleProductX.AutoSize = true;
            this.mchkSetInvisibleProductX.Checked = global::WegasWixConverter2.Properties.Settings.Default.MchkSetInvisibleProductXState;
            this.mchkSetInvisibleProductX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkSetInvisibleProductX.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WegasWixConverter2.Properties.Settings.Default, "MchkSetInvisibleProductXState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mchkSetInvisibleProductX.Depth = 0;
            this.mchkSetInvisibleProductX.Location = new System.Drawing.Point(13, 150);
            this.mchkSetInvisibleProductX.Margin = new System.Windows.Forms.Padding(0);
            this.mchkSetInvisibleProductX.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkSetInvisibleProductX.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkSetInvisibleProductX.Name = "mchkSetInvisibleProductX";
            this.mchkSetInvisibleProductX.ReadOnly = false;
            this.mchkSetInvisibleProductX.Ripple = true;
            this.mchkSetInvisibleProductX.Size = new System.Drawing.Size(274, 37);
            this.mchkSetInvisibleProductX.TabIndex = 3;
            this.mchkSetInvisibleProductX.Text = "Rendi invisibili prodotti dismessi\r\n";
            this.mchkSetInvisibleProductX.UseVisualStyleBackColor = true;
            this.mchkSetInvisibleProductX.CheckedChanged += new System.EventHandler(this.mchkSetInvisibleProductX_CheckedChanged);
            // 
            // mchkUpdatePrice
            // 
            this.mchkUpdatePrice.AutoSize = true;
            this.mchkUpdatePrice.Checked = global::WegasWixConverter2.Properties.Settings.Default.MchkUpdatePriceState;
            this.mchkUpdatePrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkUpdatePrice.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WegasWixConverter2.Properties.Settings.Default, "MchkUpdatePriceState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mchkUpdatePrice.Depth = 0;
            this.mchkUpdatePrice.Location = new System.Drawing.Point(13, 76);
            this.mchkUpdatePrice.Margin = new System.Windows.Forms.Padding(0);
            this.mchkUpdatePrice.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkUpdatePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkUpdatePrice.Name = "mchkUpdatePrice";
            this.mchkUpdatePrice.ReadOnly = false;
            this.mchkUpdatePrice.Ripple = true;
            this.mchkUpdatePrice.Size = new System.Drawing.Size(150, 37);
            this.mchkUpdatePrice.TabIndex = 2;
            this.mchkUpdatePrice.Text = "Aggiorna prezzo";
            this.mchkUpdatePrice.UseVisualStyleBackColor = true;
            this.mchkUpdatePrice.CheckedChanged += new System.EventHandler(this.mchkUpdatePrice_CheckedChanged);
            // 
            // mlblBehavior
            // 
            this.mlblBehavior.AutoSize = true;
            this.mlblBehavior.Depth = 0;
            this.mlblBehavior.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblBehavior.Location = new System.Drawing.Point(10, 13);
            this.mlblBehavior.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblBehavior.Name = "mlblBehavior";
            this.mlblBehavior.Size = new System.Drawing.Size(116, 19);
            this.mlblBehavior.TabIndex = 1;
            this.mlblBehavior.Text = "Comportamento";
            // 
            // mchkConsiderReservations
            // 
            this.mchkConsiderReservations.AutoSize = true;
            this.mchkConsiderReservations.Checked = global::WegasWixConverter2.Properties.Settings.Default.MchkConsiderReservationsState;
            this.mchkConsiderReservations.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WegasWixConverter2.Properties.Settings.Default, "MchkConsiderReservationsState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mchkConsiderReservations.Depth = 0;
            this.mchkConsiderReservations.Location = new System.Drawing.Point(13, 113);
            this.mchkConsiderReservations.Margin = new System.Windows.Forms.Padding(0);
            this.mchkConsiderReservations.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchkConsiderReservations.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchkConsiderReservations.Name = "mchkConsiderReservations";
            this.mchkConsiderReservations.ReadOnly = false;
            this.mchkConsiderReservations.Ripple = true;
            this.mchkConsiderReservations.Size = new System.Drawing.Size(191, 37);
            this.mchkConsiderReservations.TabIndex = 0;
            this.mchkConsiderReservations.Text = "Considera riservazioni";
            this.mchkConsiderReservations.UseVisualStyleBackColor = true;
            // 
            // gbxTheme
            // 
            this.gbxTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxTheme.Controls.Add(this.mlblTheme);
            this.gbxTheme.Controls.Add(this.mswtTheme);
            this.gbxTheme.Location = new System.Drawing.Point(66, 312);
            this.gbxTheme.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTheme.Name = "gbxTheme";
            this.gbxTheme.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTheme.Size = new System.Drawing.Size(300, 70);
            this.gbxTheme.TabIndex = 7;
            this.gbxTheme.TabStop = false;
            // 
            // mlblTheme
            // 
            this.mlblTheme.AutoSize = true;
            this.mlblTheme.Depth = 0;
            this.mlblTheme.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblTheme.Location = new System.Drawing.Point(58, 27);
            this.mlblTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblTheme.Name = "mlblTheme";
            this.mlblTheme.Size = new System.Drawing.Size(42, 19);
            this.mlblTheme.TabIndex = 1;
            this.mlblTheme.Text = "Tema";
            // 
            // mswtTheme
            // 
            this.mswtTheme.AutoSize = true;
            this.mswtTheme.Depth = 0;
            this.mswtTheme.Location = new System.Drawing.Point(124, 20);
            this.mswtTheme.Margin = new System.Windows.Forms.Padding(0);
            this.mswtTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mswtTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.mswtTheme.Name = "mswtTheme";
            this.mswtTheme.Ripple = true;
            this.mswtTheme.Size = new System.Drawing.Size(99, 37);
            this.mswtTheme.TabIndex = 0;
            this.mswtTheme.Text = "Scuro";
            this.mswtTheme.UseVisualStyleBackColor = true;
            this.mswtTheme.CheckedChanged += new System.EventHandler(this.mswtTheme_CheckedChanged);
            // 
            // gbxColorScheme
            // 
            this.gbxColorScheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxColorScheme.Controls.Add(this.mrbtnPink);
            this.gbxColorScheme.Controls.Add(this.mrbtnGrey);
            this.gbxColorScheme.Controls.Add(this.mrbtnAmber);
            this.gbxColorScheme.Controls.Add(this.mrbtnCyan);
            this.gbxColorScheme.Controls.Add(this.mrbtnPurple);
            this.gbxColorScheme.Controls.Add(this.mrbtnBlue);
            this.gbxColorScheme.Controls.Add(this.mlblSchemaColori);
            this.gbxColorScheme.Controls.Add(this.mrbtnOrange);
            this.gbxColorScheme.Controls.Add(this.mrbtnRed);
            this.gbxColorScheme.Controls.Add(this.mrbtnGreen);
            this.gbxColorScheme.Location = new System.Drawing.Point(400, 48);
            this.gbxColorScheme.Margin = new System.Windows.Forms.Padding(2);
            this.gbxColorScheme.Name = "gbxColorScheme";
            this.gbxColorScheme.Padding = new System.Windows.Forms.Padding(2);
            this.gbxColorScheme.Size = new System.Drawing.Size(310, 334);
            this.gbxColorScheme.TabIndex = 6;
            this.gbxColorScheme.TabStop = false;
            // 
            // mrbtnPink
            // 
            this.mrbtnPink.AutoSize = true;
            this.mrbtnPink.Depth = 0;
            this.mrbtnPink.Location = new System.Drawing.Point(162, 269);
            this.mrbtnPink.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnPink.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnPink.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnPink.Name = "mrbtnPink";
            this.mrbtnPink.Ripple = true;
            this.mrbtnPink.Size = new System.Drawing.Size(71, 37);
            this.mrbtnPink.TabIndex = 11;
            this.mrbtnPink.TabStop = true;
            this.mrbtnPink.Text = "Rosa";
            this.mrbtnPink.UseVisualStyleBackColor = true;
            this.mrbtnPink.CheckedChanged += new System.EventHandler(this.mrbtnPink_CheckedChanged);
            // 
            // mrbtnGrey
            // 
            this.mrbtnGrey.AutoSize = true;
            this.mrbtnGrey.Depth = 0;
            this.mrbtnGrey.Location = new System.Drawing.Point(162, 30);
            this.mrbtnGrey.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnGrey.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnGrey.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnGrey.Name = "mrbtnGrey";
            this.mrbtnGrey.Ripple = true;
            this.mrbtnGrey.Size = new System.Drawing.Size(77, 37);
            this.mrbtnGrey.TabIndex = 10;
            this.mrbtnGrey.TabStop = true;
            this.mrbtnGrey.Text = "Grigio";
            this.mrbtnGrey.UseVisualStyleBackColor = true;
            this.mrbtnGrey.CheckedChanged += new System.EventHandler(this.mrbtnGrey_CheckedChanged);
            // 
            // mrbtnAmber
            // 
            this.mrbtnAmber.AutoSize = true;
            this.mrbtnAmber.Depth = 0;
            this.mrbtnAmber.Location = new System.Drawing.Point(162, 239);
            this.mrbtnAmber.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnAmber.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnAmber.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnAmber.Name = "mrbtnAmber";
            this.mrbtnAmber.Ripple = true;
            this.mrbtnAmber.Size = new System.Drawing.Size(82, 37);
            this.mrbtnAmber.TabIndex = 9;
            this.mrbtnAmber.TabStop = true;
            this.mrbtnAmber.Text = "Ambra";
            this.mrbtnAmber.UseVisualStyleBackColor = true;
            this.mrbtnAmber.CheckedChanged += new System.EventHandler(this.mrbtnAmber_CheckedChanged);
            // 
            // mrbtnCyan
            // 
            this.mrbtnCyan.AutoSize = true;
            this.mrbtnCyan.Depth = 0;
            this.mrbtnCyan.Location = new System.Drawing.Point(162, 209);
            this.mrbtnCyan.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnCyan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnCyan.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnCyan.Name = "mrbtnCyan";
            this.mrbtnCyan.Ripple = true;
            this.mrbtnCyan.Size = new System.Drawing.Size(76, 37);
            this.mrbtnCyan.TabIndex = 8;
            this.mrbtnCyan.TabStop = true;
            this.mrbtnCyan.Text = "Ciano";
            this.mrbtnCyan.UseVisualStyleBackColor = true;
            this.mrbtnCyan.CheckedChanged += new System.EventHandler(this.mrbtnCyan_CheckedChanged);
            // 
            // mrbtnPurple
            // 
            this.mrbtnPurple.AutoSize = true;
            this.mrbtnPurple.Depth = 0;
            this.mrbtnPurple.Location = new System.Drawing.Point(162, 179);
            this.mrbtnPurple.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnPurple.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnPurple.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnPurple.Name = "mrbtnPurple";
            this.mrbtnPurple.Ripple = true;
            this.mrbtnPurple.Size = new System.Drawing.Size(71, 37);
            this.mrbtnPurple.TabIndex = 7;
            this.mrbtnPurple.TabStop = true;
            this.mrbtnPurple.Text = "Viola";
            this.mrbtnPurple.UseVisualStyleBackColor = true;
            this.mrbtnPurple.CheckedChanged += new System.EventHandler(this.mrbtnPurple_CheckedChanged);
            // 
            // mrbtnBlue
            // 
            this.mrbtnBlue.AutoSize = true;
            this.mrbtnBlue.Depth = 0;
            this.mrbtnBlue.Location = new System.Drawing.Point(162, 60);
            this.mrbtnBlue.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnBlue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnBlue.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnBlue.Name = "mrbtnBlue";
            this.mrbtnBlue.Ripple = true;
            this.mrbtnBlue.Size = new System.Drawing.Size(58, 37);
            this.mrbtnBlue.TabIndex = 6;
            this.mrbtnBlue.TabStop = true;
            this.mrbtnBlue.Text = "Blu";
            this.mrbtnBlue.UseVisualStyleBackColor = true;
            this.mrbtnBlue.CheckedChanged += new System.EventHandler(this.mrbtnBlue_CheckedChanged);
            // 
            // mlblSchemaColori
            // 
            this.mlblSchemaColori.AutoSize = true;
            this.mlblSchemaColori.Depth = 0;
            this.mlblSchemaColori.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblSchemaColori.Location = new System.Drawing.Point(48, 160);
            this.mlblSchemaColori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblSchemaColori.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblSchemaColori.Name = "mlblSchemaColori";
            this.mlblSchemaColori.Size = new System.Drawing.Size(104, 19);
            this.mlblSchemaColori.TabIndex = 5;
            this.mlblSchemaColori.Text = "Schema Colori";
            // 
            // mrbtnOrange
            // 
            this.mrbtnOrange.AutoSize = true;
            this.mrbtnOrange.Depth = 0;
            this.mrbtnOrange.Location = new System.Drawing.Point(162, 120);
            this.mrbtnOrange.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnOrange.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnOrange.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnOrange.Name = "mrbtnOrange";
            this.mrbtnOrange.Ripple = true;
            this.mrbtnOrange.Size = new System.Drawing.Size(89, 37);
            this.mrbtnOrange.TabIndex = 4;
            this.mrbtnOrange.TabStop = true;
            this.mrbtnOrange.Text = "Arancio";
            this.mrbtnOrange.UseVisualStyleBackColor = true;
            this.mrbtnOrange.CheckedChanged += new System.EventHandler(this.mrbtnOrange_CheckedChanged);
            // 
            // mrbtnRed
            // 
            this.mrbtnRed.AutoSize = true;
            this.mrbtnRed.Checked = true;
            this.mrbtnRed.Depth = 0;
            this.mrbtnRed.Location = new System.Drawing.Point(162, 149);
            this.mrbtnRed.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnRed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnRed.Name = "mrbtnRed";
            this.mrbtnRed.Ripple = true;
            this.mrbtnRed.Size = new System.Drawing.Size(79, 37);
            this.mrbtnRed.TabIndex = 3;
            this.mrbtnRed.TabStop = true;
            this.mrbtnRed.Text = "Rosso";
            this.mrbtnRed.UseVisualStyleBackColor = true;
            this.mrbtnRed.CheckedChanged += new System.EventHandler(this.mrbtnRed_CheckedChanged);
            // 
            // mrbtnGreen
            // 
            this.mrbtnGreen.AutoSize = true;
            this.mrbtnGreen.Depth = 0;
            this.mrbtnGreen.Location = new System.Drawing.Point(162, 90);
            this.mrbtnGreen.Margin = new System.Windows.Forms.Padding(0);
            this.mrbtnGreen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbtnGreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnGreen.Name = "mrbtnGreen";
            this.mrbtnGreen.Ripple = true;
            this.mrbtnGreen.Size = new System.Drawing.Size(75, 37);
            this.mrbtnGreen.TabIndex = 2;
            this.mrbtnGreen.TabStop = true;
            this.mrbtnGreen.Text = "Verde";
            this.mrbtnGreen.UseVisualStyleBackColor = true;
            this.mrbtnGreen.CheckedChanged += new System.EventHandler(this.mrbtnGreen_CheckedChanged);
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "house-solid.png");
            this.imageListMenu.Images.SetKeyName(1, "cloud-arrow-down-solid.png");
            this.imageListMenu.Images.SetKeyName(2, "cash-register-solid.png");
            this.imageListMenu.Images.SetKeyName(3, "wix-brands.png");
            this.imageListMenu.Images.SetKeyName(4, "tag-solid.png");
            this.imageListMenu.Images.SetKeyName(5, "cart-shopping-solid.png");
            this.imageListMenu.Images.SetKeyName(6, "screwdriver-wrench-solid.png");
            // 
            // imageListLogo
            // 
            this.imageListLogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLogo.ImageStream")));
            this.imageListLogo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLogo.Images.SetKeyName(0, "AmberLogo.png");
            this.imageListLogo.Images.SetKeyName(1, "BlueLogo.png");
            this.imageListLogo.Images.SetKeyName(2, "CyanLogo.png");
            this.imageListLogo.Images.SetKeyName(3, "GreenLogo.png");
            this.imageListLogo.Images.SetKeyName(4, "OrangeLogo.png");
            this.imageListLogo.Images.SetKeyName(5, "PurpleLogo.png");
            this.imageListLogo.Images.SetKeyName(6, "RedLogo.png");
            this.imageListLogo.Images.SetKeyName(7, "PinkLogo.png");
            this.imageListLogo.Images.SetKeyName(8, "GreyLogo.png");
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "check-solid.png");
            this.imageListIcon.Images.SetKeyName(1, "magnifying-glass-solid.png");
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 569);
            this.Controls.Add(this.materialTab);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTab;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(450, 455);
            this.Name = "FormMainMenu";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wegas Wix Converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.materialTab.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.tabPageCaricaFiles.ResumeLayout(false);
            this.tabPageCaricaFiles.PerformLayout();
            this.gbxLoadCsv.ResumeLayout(false);
            this.gbxLoadCsv.PerformLayout();
            this.tabPageWegas.ResumeLayout(false);
            this.tabPageWegas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashDesk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wegasCsvBindingSource)).EndInit();
            this.tabPageWix.ResumeLayout(false);
            this.tabPageWix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wixCsvBindingSource)).EndInit();
            this.tabPageImpostazioni.ResumeLayout(false);
            this.tabPageImpostazioni.PerformLayout();
            this.gbxBehavior.ResumeLayout(false);
            this.gbxBehavior.PerformLayout();
            this.gbxTheme.ResumeLayout(false);
            this.gbxTheme.PerformLayout();
            this.gbxColorScheme.ResumeLayout(false);
            this.gbxColorScheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTab;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageCaricaFiles;
        private System.Windows.Forms.ImageList imageListMenu;
        private System.Windows.Forms.TabPage tabPageWegas;
        private System.Windows.Forms.TabPage tabPageWix;
        private System.Windows.Forms.TabPage tabPageImpostazioni;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnOrange;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnRed;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnGreen;
        private MaterialSkin.Controls.MaterialLabel mlblTheme;
        private MaterialSkin.Controls.MaterialSwitch mswtTheme;
        private System.Windows.Forms.GroupBox gbxTheme;
        private System.Windows.Forms.GroupBox gbxColorScheme;
        private MaterialSkin.Controls.MaterialLabel mlblSchemaColori;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnPurple;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnBlue;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnAmber;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnCyan;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ImageList imageListLogo;
        private CircularProgressBar.CircularProgressBar circularProgressClock;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnPink;
        private MaterialSkin.Controls.MaterialRadioButton mrbtnGrey;
        private System.Windows.Forms.GroupBox gbxLoadCsv;
        private MaterialSkin.Controls.MaterialTextBox2 mtbxCashDeskPath;
        private MaterialSkin.Controls.MaterialButton mbtnCashDeskLoad;
        private MaterialSkin.Controls.MaterialLabel lblLoadCashDeskCsv;
        private MaterialSkin.Controls.MaterialButton mbtnCashDeskDelete;
        private System.Windows.Forms.ImageList imageListIcon;
        private MaterialSkin.Controls.MaterialButton mbtnWixDelete;
        private MaterialSkin.Controls.MaterialLabel lblLoadWixCsv;
        private MaterialSkin.Controls.MaterialButton mbtnWixLoad;
        private MaterialSkin.Controls.MaterialTextBox2 mtbxWixPath;
        private System.Windows.Forms.DataGridView dgvWix;
        private System.Windows.Forms.BindingSource wixCsvBindingSource;
        private System.Windows.Forms.DataGridView dgvCashDesk;
        private MaterialSkin.Controls.MaterialButton mbtnExportCsv;
        private MaterialSkin.Controls.MaterialButton mbtnWixFound;
        private MaterialSkin.Controls.MaterialTextBox2 mtbxWixDgvSearch;
        private MaterialSkin.Controls.MaterialLabel mlblWixSelectedRecord;
        private MaterialSkin.Controls.MaterialButton mbtnNextWixRow;
        private MaterialSkin.Controls.MaterialButton mbtnPreviousWixRow;
        private MaterialSkin.Controls.MaterialLabel mlblDateTime;
        private System.Windows.Forms.BindingSource wegasCsvBindingSource;
        private MaterialSkin.Controls.MaterialButton mbtnPreviousCashDeskRow;
        private MaterialSkin.Controls.MaterialButton mbtnNextCashDeskRow;
        private MaterialSkin.Controls.MaterialButton mbtnCashDeskFound;
        private MaterialSkin.Controls.MaterialTextBox2 mtbxCashDeskDgvSearch;
        private MaterialSkin.Controls.MaterialLabel mlblCashDeskSelectedRecord;
        private MaterialSkin.Controls.MaterialButton mbtnDeleteWixSearch;
        private MaterialSkin.Controls.MaterialButton mbtnDeleteCashDeskSearch;
        private System.Windows.Forms.GroupBox gbxBehavior;
        private MaterialSkin.Controls.MaterialCheckbox mchkConsiderReservations;
        private MaterialSkin.Controls.MaterialLabel mlblBehavior;
        private MaterialSkin.Controls.MaterialCheckbox mchkUpdatePrice;
        private MaterialSkin.Controls.MaterialCheckbox mchkSetInvisibleProductX;
        private MaterialSkin.Controls.MaterialCheckbox mchkSetInvisibleProductWithoutSku;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroArticoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiaveDiRicercaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liberoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAttualeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riservazioniOrdiniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezziLivello5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attivoInattivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImageUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ribbonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionName1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionType1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionDescription1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionName2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionType2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionDescription2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionName3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionType3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionDescription3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionName4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionType4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionDescription4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionName5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionType5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionDescription5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionName6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionType6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOptionDescription6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoTitle1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDescription1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoTitle2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDescription2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoTitle3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDescription3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoTitle4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDescription4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoTitle5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDescription5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoTitle6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInfoDescription6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customTextField1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customTextCharLimit1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customTextMandatory1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customTextField2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customTextCharLimit2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customTextMandatory2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialCheckbox mchkUpdateQuantity;
        private MaterialSkin.Controls.MaterialLabel mlblOptionsWarningMessage1;
        private MaterialSkin.Controls.MaterialLabel mlblOptionsWarningMessage2;
        private MaterialSkin.Controls.MaterialLabel mlblLoadFilesWarningMessage2;
        private MaterialSkin.Controls.MaterialLabel mlblLoadFilesWarningMessage1;
    }
}

