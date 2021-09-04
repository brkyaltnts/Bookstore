
namespace Bookstore.WindowsFormsUI
{
    partial class frmHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.rcMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBookSell = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookRent = new DevExpress.XtraBars.BarButtonItem();
            this.btnRents = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookByAuthor = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookByPublisher = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookByType = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookSell2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookRent2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRents2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookStockAmountAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnAuthorList = new DevExpress.XtraBars.BarButtonItem();
            this.btnAuthorAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnAuthorsBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnPublisherList = new DevExpress.XtraBars.BarButtonItem();
            this.btnPublisherAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnPublishersBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnReaderList = new DevExpress.XtraBars.BarButtonItem();
            this.btnReaderAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnPoints = new DevExpress.XtraBars.BarButtonItem();
            this.btnTypeList = new DevExpress.XtraBars.BarButtonItem();
            this.btnTypeAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnTypesBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployeeList = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployeeAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnMaximized = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalculator = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnWord = new DevExpress.XtraBars.BarButtonItem();
            this.rpHomePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSellOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgLists = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBook = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSellOperations2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBookOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpReader = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgReaderOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAuthorPublisherType = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAuthorOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPublisherOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTypeOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpEmployee = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgEmployeeOperations = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgVehicles = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rcMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // rcMenu
            // 
            this.rcMenu.AllowMinimizeRibbon = false;
            this.rcMenu.ExpandCollapseItem.Id = 0;
            this.rcMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMenu.ExpandCollapseItem,
            this.rcMenu.SearchEditItem,
            this.btnBookSell,
            this.btnBookRent,
            this.btnRents,
            this.btnBookByAuthor,
            this.btnBookByPublisher,
            this.btnBookByType,
            this.btnBookSell2,
            this.btnBookRent2,
            this.btnRents2,
            this.btnBookAdd,
            this.btnBookStockAmountAdd,
            this.btnAuthorList,
            this.btnAuthorAdd,
            this.btnAuthorsBook,
            this.btnPublisherList,
            this.btnPublisherAdd,
            this.btnPublishersBook,
            this.btnReaderList,
            this.btnReaderAdd,
            this.btnPoints,
            this.btnTypeList,
            this.btnTypeAdd,
            this.btnTypesBook,
            this.btnEmployeeList,
            this.btnEmployeeAdd,
            this.btnExit,
            this.btnMaximized,
            this.btnCalculator,
            this.btnExcel,
            this.btnWord});
            this.rcMenu.Location = new System.Drawing.Point(0, 0);
            this.rcMenu.MaxItemId = 36;
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.PageHeaderItemLinks.Add(this.btnMaximized);
            this.rcMenu.PageHeaderItemLinks.Add(this.btnExit);
            this.rcMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHomePage,
            this.rpBook,
            this.rpReader,
            this.rpAuthorPublisherType,
            this.rpEmployee,
            this.rpReports});
            this.rcMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.rcMenu.ShowToolbarCustomizeItem = false;
            this.rcMenu.Size = new System.Drawing.Size(1366, 150);
            this.rcMenu.Toolbar.ShowCustomizeItem = false;
            // 
            // btnBookSell
            // 
            this.btnBookSell.Caption = "Kitap Sat";
            this.btnBookSell.Id = 1;
            this.btnBookSell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSell.ImageOptions.Image")));
            this.btnBookSell.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookSell.ImageOptions.LargeImage")));
            this.btnBookSell.Name = "btnBookSell";
            this.btnBookSell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBookSell_ItemClick);
            // 
            // btnBookRent
            // 
            this.btnBookRent.Caption = "Kitap Kirala";
            this.btnBookRent.Id = 2;
            this.btnBookRent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookRent.ImageOptions.Image")));
            this.btnBookRent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookRent.ImageOptions.LargeImage")));
            this.btnBookRent.Name = "btnBookRent";
            // 
            // btnRents
            // 
            this.btnRents.Caption = "Kiradaki Kitaplar";
            this.btnRents.Id = 3;
            this.btnRents.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRents.ImageOptions.Image")));
            this.btnRents.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRents.ImageOptions.LargeImage")));
            this.btnRents.Name = "btnRents";
            // 
            // btnBookByAuthor
            // 
            this.btnBookByAuthor.Caption = "Yazarlara Göre Kitaplar";
            this.btnBookByAuthor.Id = 4;
            this.btnBookByAuthor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookByAuthor.ImageOptions.Image")));
            this.btnBookByAuthor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookByAuthor.ImageOptions.LargeImage")));
            this.btnBookByAuthor.Name = "btnBookByAuthor";
            // 
            // btnBookByPublisher
            // 
            this.btnBookByPublisher.Caption = "Yayınevlerine Göre Kitaplar";
            this.btnBookByPublisher.Id = 5;
            this.btnBookByPublisher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookByPublisher.ImageOptions.Image")));
            this.btnBookByPublisher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookByPublisher.ImageOptions.LargeImage")));
            this.btnBookByPublisher.Name = "btnBookByPublisher";
            // 
            // btnBookByType
            // 
            this.btnBookByType.Caption = "Türüne Göre Kitaplar";
            this.btnBookByType.Id = 6;
            this.btnBookByType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookByType.ImageOptions.Image")));
            this.btnBookByType.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookByType.ImageOptions.LargeImage")));
            this.btnBookByType.Name = "btnBookByType";
            // 
            // btnBookSell2
            // 
            this.btnBookSell2.Caption = "Kitap Sat";
            this.btnBookSell2.Id = 7;
            this.btnBookSell2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSell2.ImageOptions.Image")));
            this.btnBookSell2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookSell2.ImageOptions.LargeImage")));
            this.btnBookSell2.Name = "btnBookSell2";
            // 
            // btnBookRent2
            // 
            this.btnBookRent2.Caption = "Kitap Kirala";
            this.btnBookRent2.Id = 8;
            this.btnBookRent2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookRent2.ImageOptions.Image")));
            this.btnBookRent2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookRent2.ImageOptions.LargeImage")));
            this.btnBookRent2.Name = "btnBookRent2";
            // 
            // btnRents2
            // 
            this.btnRents2.Caption = "Kiradaki Kitaplar";
            this.btnRents2.Id = 9;
            this.btnRents2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRents2.ImageOptions.Image")));
            this.btnRents2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRents2.ImageOptions.LargeImage")));
            this.btnRents2.Name = "btnRents2";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Caption = "Yeni Kitap Ekle";
            this.btnBookAdd.Id = 10;
            this.btnBookAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookAdd.ImageOptions.Image")));
            this.btnBookAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookAdd.ImageOptions.LargeImage")));
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBookAdd_ItemClick);
            // 
            // btnBookStockAmountAdd
            // 
            this.btnBookStockAmountAdd.Caption = "Stok Ekle";
            this.btnBookStockAmountAdd.Id = 11;
            this.btnBookStockAmountAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookStockAmountAdd.ImageOptions.Image")));
            this.btnBookStockAmountAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookStockAmountAdd.ImageOptions.LargeImage")));
            this.btnBookStockAmountAdd.Name = "btnBookStockAmountAdd";
            // 
            // btnAuthorList
            // 
            this.btnAuthorList.Caption = "Yazar Listesi";
            this.btnAuthorList.Id = 12;
            this.btnAuthorList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthorList.ImageOptions.Image")));
            this.btnAuthorList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAuthorList.ImageOptions.LargeImage")));
            this.btnAuthorList.Name = "btnAuthorList";
            this.btnAuthorList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAuthorList_ItemClick);
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Caption = "Yazar Ekle";
            this.btnAuthorAdd.Id = 13;
            this.btnAuthorAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthorAdd.ImageOptions.Image")));
            this.btnAuthorAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAuthorAdd.ImageOptions.LargeImage")));
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAuthorAdd_ItemClick);
            // 
            // btnAuthorsBook
            // 
            this.btnAuthorsBook.Caption = "Yazarlara Göre Kitaplar";
            this.btnAuthorsBook.Id = 14;
            this.btnAuthorsBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthorsBook.ImageOptions.Image")));
            this.btnAuthorsBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAuthorsBook.ImageOptions.LargeImage")));
            this.btnAuthorsBook.Name = "btnAuthorsBook";
            // 
            // btnPublisherList
            // 
            this.btnPublisherList.Caption = "Yayınevi Listesi";
            this.btnPublisherList.Id = 15;
            this.btnPublisherList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPublisherList.ImageOptions.Image")));
            this.btnPublisherList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPublisherList.ImageOptions.LargeImage")));
            this.btnPublisherList.Name = "btnPublisherList";
            this.btnPublisherList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPublisherList_ItemClick);
            // 
            // btnPublisherAdd
            // 
            this.btnPublisherAdd.Caption = "Yayınevi Ekle";
            this.btnPublisherAdd.Id = 16;
            this.btnPublisherAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPublisherAdd.ImageOptions.Image")));
            this.btnPublisherAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPublisherAdd.ImageOptions.LargeImage")));
            this.btnPublisherAdd.Name = "btnPublisherAdd";
            this.btnPublisherAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPublisherAdd_ItemClick);
            // 
            // btnPublishersBook
            // 
            this.btnPublishersBook.Caption = "Yayınevine Göre Kitaplar";
            this.btnPublishersBook.Id = 17;
            this.btnPublishersBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPublishersBook.ImageOptions.Image")));
            this.btnPublishersBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPublishersBook.ImageOptions.LargeImage")));
            this.btnPublishersBook.Name = "btnPublishersBook";
            // 
            // btnReaderList
            // 
            this.btnReaderList.Caption = "Okuyucu Listesi";
            this.btnReaderList.Id = 18;
            this.btnReaderList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderList.ImageOptions.Image")));
            this.btnReaderList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReaderList.ImageOptions.LargeImage")));
            this.btnReaderList.Name = "btnReaderList";
            this.btnReaderList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReaderList_ItemClick);
            // 
            // btnReaderAdd
            // 
            this.btnReaderAdd.Caption = "Okuyucu Ekle";
            this.btnReaderAdd.Id = 19;
            this.btnReaderAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderAdd.ImageOptions.Image")));
            this.btnReaderAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReaderAdd.ImageOptions.LargeImage")));
            this.btnReaderAdd.Name = "btnReaderAdd";
            this.btnReaderAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReaderAdd_ItemClick);
            // 
            // btnPoints
            // 
            this.btnPoints.Caption = "Puan Sıralaması";
            this.btnPoints.Id = 20;
            this.btnPoints.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPoints.ImageOptions.Image")));
            this.btnPoints.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPoints.ImageOptions.LargeImage")));
            this.btnPoints.Name = "btnPoints";
            // 
            // btnTypeList
            // 
            this.btnTypeList.Caption = "Tür Listesi";
            this.btnTypeList.Id = 22;
            this.btnTypeList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTypeList.ImageOptions.Image")));
            this.btnTypeList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTypeList.ImageOptions.LargeImage")));
            this.btnTypeList.Name = "btnTypeList";
            this.btnTypeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTypeList_ItemClick);
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.Caption = "Tür Ekle";
            this.btnTypeAdd.Id = 23;
            this.btnTypeAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTypeAdd.ImageOptions.Image")));
            this.btnTypeAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTypeAdd.ImageOptions.LargeImage")));
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTypeAdd_ItemClick);
            // 
            // btnTypesBook
            // 
            this.btnTypesBook.Caption = "Türüne Göre Kitaplar";
            this.btnTypesBook.Id = 24;
            this.btnTypesBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTypesBook.ImageOptions.Image")));
            this.btnTypesBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTypesBook.ImageOptions.LargeImage")));
            this.btnTypesBook.Name = "btnTypesBook";
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.Caption = "Personel Listesi";
            this.btnEmployeeList.Id = 25;
            this.btnEmployeeList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeList.ImageOptions.Image")));
            this.btnEmployeeList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeList.ImageOptions.LargeImage")));
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployeeList_ItemClick);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Caption = "Personel Ekle";
            this.btnEmployeeAdd.Id = 27;
            this.btnEmployeeAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeAdd.ImageOptions.Image")));
            this.btnEmployeeAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeAdd.ImageOptions.LargeImage")));
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployeeAdd_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Id = 28;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Id = 32;
            this.btnMaximized.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.ImageOptions.Image")));
            this.btnMaximized.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMaximized.ImageOptions.LargeImage")));
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMaximized_ItemClick);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Caption = "Hesap Makinesi";
            this.btnCalculator.Id = 33;
            this.btnCalculator.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.ImageOptions.Image")));
            this.btnCalculator.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCalculator.ImageOptions.LargeImage")));
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalculator_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excel";
            this.btnExcel.Id = 34;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.LargeImage")));
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // btnWord
            // 
            this.btnWord.Caption = "Word";
            this.btnWord.Id = 35;
            this.btnWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWord.ImageOptions.Image")));
            this.btnWord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWord.ImageOptions.LargeImage")));
            this.btnWord.Name = "btnWord";
            this.btnWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWord_ItemClick);
            // 
            // rpHomePage
            // 
            this.rpHomePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSellOperations,
            this.rpgLists});
            this.rpHomePage.Name = "rpHomePage";
            this.rpHomePage.Text = "Anasayfa";
            // 
            // rpgSellOperations
            // 
            this.rpgSellOperations.ItemLinks.Add(this.btnBookSell);
            this.rpgSellOperations.ItemLinks.Add(this.btnBookRent);
            this.rpgSellOperations.Name = "rpgSellOperations";
            this.rpgSellOperations.Text = "Satış İşlemleri";
            // 
            // rpgLists
            // 
            this.rpgLists.ItemLinks.Add(this.btnRents);
            this.rpgLists.ItemLinks.Add(this.btnBookByAuthor);
            this.rpgLists.ItemLinks.Add(this.btnBookByPublisher);
            this.rpgLists.ItemLinks.Add(this.btnBookByType);
            this.rpgLists.Name = "rpgLists";
            this.rpgLists.Text = "Listeler";
            // 
            // rpBook
            // 
            this.rpBook.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSellOperations2,
            this.rpgBookOperations});
            this.rpBook.Name = "rpBook";
            this.rpBook.Text = "Kitap";
            // 
            // rpgSellOperations2
            // 
            this.rpgSellOperations2.ItemLinks.Add(this.btnBookSell2);
            this.rpgSellOperations2.ItemLinks.Add(this.btnBookRent2);
            this.rpgSellOperations2.Name = "rpgSellOperations2";
            this.rpgSellOperations2.Text = "Satış İşlemleri";
            // 
            // rpgBookOperations
            // 
            this.rpgBookOperations.ItemLinks.Add(this.btnRents2);
            this.rpgBookOperations.ItemLinks.Add(this.btnBookAdd);
            this.rpgBookOperations.ItemLinks.Add(this.btnBookStockAmountAdd);
            this.rpgBookOperations.Name = "rpgBookOperations";
            this.rpgBookOperations.Text = "Kitap İşlemleri";
            // 
            // rpReader
            // 
            this.rpReader.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgReaderOperations});
            this.rpReader.Name = "rpReader";
            this.rpReader.Text = "Okuyucu";
            // 
            // rpgReaderOperations
            // 
            this.rpgReaderOperations.ItemLinks.Add(this.btnReaderList);
            this.rpgReaderOperations.ItemLinks.Add(this.btnReaderAdd);
            this.rpgReaderOperations.ItemLinks.Add(this.btnPoints);
            this.rpgReaderOperations.Name = "rpgReaderOperations";
            this.rpgReaderOperations.Text = "Okuyucu İşlemleri";
            // 
            // rpAuthorPublisherType
            // 
            this.rpAuthorPublisherType.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAuthorOperations,
            this.rpgPublisherOperations,
            this.rpgTypeOperations});
            this.rpAuthorPublisherType.Name = "rpAuthorPublisherType";
            this.rpAuthorPublisherType.Text = "Yazar/Yayınevi/Tür";
            // 
            // rpgAuthorOperations
            // 
            this.rpgAuthorOperations.ItemLinks.Add(this.btnAuthorList);
            this.rpgAuthorOperations.ItemLinks.Add(this.btnAuthorAdd);
            this.rpgAuthorOperations.ItemLinks.Add(this.btnAuthorsBook);
            this.rpgAuthorOperations.Name = "rpgAuthorOperations";
            this.rpgAuthorOperations.Text = "Yazar İşlemleri";
            // 
            // rpgPublisherOperations
            // 
            this.rpgPublisherOperations.ItemLinks.Add(this.btnPublisherList);
            this.rpgPublisherOperations.ItemLinks.Add(this.btnPublisherAdd);
            this.rpgPublisherOperations.ItemLinks.Add(this.btnPublishersBook);
            this.rpgPublisherOperations.Name = "rpgPublisherOperations";
            this.rpgPublisherOperations.Text = "Yayınevi İşlemleri";
            // 
            // rpgTypeOperations
            // 
            this.rpgTypeOperations.ItemLinks.Add(this.btnTypeList);
            this.rpgTypeOperations.ItemLinks.Add(this.btnTypeAdd);
            this.rpgTypeOperations.ItemLinks.Add(this.btnTypesBook);
            this.rpgTypeOperations.Name = "rpgTypeOperations";
            this.rpgTypeOperations.Text = "Tür İşlemleri";
            // 
            // rpEmployee
            // 
            this.rpEmployee.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgEmployeeOperations});
            this.rpEmployee.Name = "rpEmployee";
            this.rpEmployee.Text = "Personel";
            // 
            // rpgEmployeeOperations
            // 
            this.rpgEmployeeOperations.ItemLinks.Add(this.btnEmployeeList);
            this.rpgEmployeeOperations.ItemLinks.Add(this.btnEmployeeAdd);
            this.rpgEmployeeOperations.Name = "rpgEmployeeOperations";
            this.rpgEmployeeOperations.Text = "Personel İşlemleri";
            // 
            // rpReports
            // 
            this.rpReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgVehicles});
            this.rpReports.Name = "rpReports";
            this.rpReports.Text = "Raporlar";
            // 
            // rpgVehicles
            // 
            this.rpgVehicles.ItemLinks.Add(this.btnCalculator);
            this.rpgVehicles.ItemLinks.Add(this.btnExcel);
            this.rpgVehicles.ItemLinks.Add(this.btnWord);
            this.rpgVehicles.Name = "rpgVehicles";
            this.rpgVehicles.Text = "Araçlar";
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.rcMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookstore v0.0";
            ((System.ComponentModel.ISupportInitialize)(this.rcMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHomePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSellOperations;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBook;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSellOperations2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAuthorPublisherType;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAuthorOperations;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReader;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReaderOperations;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReports;
        private DevExpress.XtraBars.BarButtonItem btnBookSell;
        private DevExpress.XtraBars.BarButtonItem btnBookRent;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgEmployeeOperations;
        private DevExpress.XtraBars.BarButtonItem btnRents;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgLists;
        private DevExpress.XtraBars.BarButtonItem btnBookByAuthor;
        private DevExpress.XtraBars.BarButtonItem btnBookByPublisher;
        private DevExpress.XtraBars.BarButtonItem btnBookByType;
        private DevExpress.XtraBars.BarButtonItem btnBookSell2;
        private DevExpress.XtraBars.BarButtonItem btnBookRent2;
        private DevExpress.XtraBars.BarButtonItem btnRents2;
        private DevExpress.XtraBars.BarButtonItem btnBookAdd;
        private DevExpress.XtraBars.BarButtonItem btnBookStockAmountAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBookOperations;
        private DevExpress.XtraBars.BarButtonItem btnAuthorList;
        private DevExpress.XtraBars.BarButtonItem btnAuthorAdd;
        private DevExpress.XtraBars.BarButtonItem btnAuthorsBook;
        private DevExpress.XtraBars.BarButtonItem btnPublisherList;
        private DevExpress.XtraBars.BarButtonItem btnPublisherAdd;
        private DevExpress.XtraBars.BarButtonItem btnPublishersBook;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPublisherOperations;
        private DevExpress.XtraBars.BarButtonItem btnReaderList;
        private DevExpress.XtraBars.BarButtonItem btnReaderAdd;
        private DevExpress.XtraBars.BarButtonItem btnPoints;
        private DevExpress.XtraBars.BarButtonItem btnTypeList;
        private DevExpress.XtraBars.BarButtonItem btnTypeAdd;
        private DevExpress.XtraBars.BarButtonItem btnTypesBook;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTypeOperations;
        private DevExpress.XtraBars.BarButtonItem btnEmployeeList;
        private DevExpress.XtraBars.BarButtonItem btnEmployeeAdd;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnMaximized;
        private DevExpress.XtraBars.BarButtonItem btnCalculator;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgVehicles;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnWord;
    }
}