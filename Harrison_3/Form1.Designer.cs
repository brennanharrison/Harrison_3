namespace Harrison_3
{
    partial class balloonForm
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
            this.components = new System.ComponentModel.Container();
            this.balloonPictureBox = new System.Windows.Forms.PictureBox();
            this.balloonLabel = new System.Windows.Forms.Label();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.stateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.zipMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.homePriceLabel = new System.Windows.Forms.Label();
            this.homeRadioButton = new System.Windows.Forms.RadioButton();
            this.storeRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryTypeLabel = new System.Windows.Forms.Label();
            this.deliveryDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.orderDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.perExtraLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageInstructionsLabel = new System.Windows.Forms.Label();
            this.messagePriceLabel = new System.Windows.Forms.Label();
            this.messageCheckBox = new System.Windows.Forms.CheckBox();
            this.extrasPriceLabel = new System.Windows.Forms.Label();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.extrasLabel = new System.Windows.Forms.Label();
            this.occasionComboBox = new System.Windows.Forms.ComboBox();
            this.occasionLabel = new System.Windows.Forms.Label();
            this.dozenPriceLabel = new System.Windows.Forms.Label();
            this.dozenRadioButton = new System.Windows.Forms.RadioButton();
            this.halfDozenPriceLabel = new System.Windows.Forms.Label();
            this.halfDozenRadioButton = new System.Windows.Forms.RadioButton();
            this.singlePriceLabel = new System.Windows.Forms.Label();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.balloonSizeLabel = new System.Windows.Forms.Label();
            this.orderTotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.orderTotalDescriptionLabel = new System.Windows.Forms.Label();
            this.orderTotalDividerGroupBox = new System.Windows.Forms.GroupBox();
            this.salesTaxAmountLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.subTotalDescriptionLabel = new System.Windows.Forms.Label();
            this.displaySummaryButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.buttonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).BeginInit();
            this.customerInformationGroupBox.SuspendLayout();
            this.deliveryInformationGroupBox.SuspendLayout();
            this.orderDetailGroupBox.SuspendLayout();
            this.orderTotalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // balloonPictureBox
            // 
            this.balloonPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.balloonPictureBox.Image = global::Harrison_3.Properties.Resources.balloons;
            this.balloonPictureBox.Location = new System.Drawing.Point(137, 15);
            this.balloonPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.balloonPictureBox.Name = "balloonPictureBox";
            this.balloonPictureBox.Size = new System.Drawing.Size(275, 110);
            this.balloonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.balloonPictureBox.TabIndex = 0;
            this.balloonPictureBox.TabStop = false;
            // 
            // balloonLabel
            // 
            this.balloonLabel.BackColor = System.Drawing.Color.Gold;
            this.balloonLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.balloonLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balloonLabel.ForeColor = System.Drawing.Color.Indigo;
            this.balloonLabel.Location = new System.Drawing.Point(440, 50);
            this.balloonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balloonLabel.Name = "balloonLabel";
            this.balloonLabel.Size = new System.Drawing.Size(256, 47);
            this.balloonLabel.TabIndex = 1;
            this.balloonLabel.Text = "Bonnie\'s Balloons";
            this.balloonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.Controls.Add(this.stateMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberLabel);
            this.customerInformationGroupBox.Controls.Add(this.zipMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.zipLabel);
            this.customerInformationGroupBox.Controls.Add(this.stateLabel);
            this.customerInformationGroupBox.Controls.Add(this.cityTextBox);
            this.customerInformationGroupBox.Controls.Add(this.cityLabel);
            this.customerInformationGroupBox.Controls.Add(this.streetTextBox);
            this.customerInformationGroupBox.Controls.Add(this.streetLabel);
            this.customerInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.titleLabel);
            this.customerInformationGroupBox.Controls.Add(this.titleComboBox);
            this.customerInformationGroupBox.Location = new System.Drawing.Point(32, 133);
            this.customerInformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerInformationGroupBox.Size = new System.Drawing.Size(779, 170);
            this.customerInformationGroupBox.TabIndex = 2;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Customer Information";
            // 
            // stateMaskedTextBox
            // 
            this.stateMaskedTextBox.Location = new System.Drawing.Point(523, 63);
            this.stateMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateMaskedTextBox.Mask = ">LL";
            this.stateMaskedTextBox.Name = "stateMaskedTextBox";
            this.stateMaskedTextBox.Size = new System.Drawing.Size(25, 22);
            this.stateMaskedTextBox.TabIndex = 11;
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.AsciiOnly = true;
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(523, 134);
            this.phoneNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(104, 22);
            this.phoneNumberMaskedTextBox.TabIndex = 15;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Location = new System.Drawing.Point(393, 132);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(109, 28);
            this.phoneNumberLabel.TabIndex = 14;
            this.phoneNumberLabel.Text = "Phone Number:";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zipMaskedTextBox
            // 
            this.zipMaskedTextBox.Location = new System.Drawing.Point(523, 98);
            this.zipMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zipMaskedTextBox.Mask = "00000";
            this.zipMaskedTextBox.Name = "zipMaskedTextBox";
            this.zipMaskedTextBox.Size = new System.Drawing.Size(47, 22);
            this.zipMaskedTextBox.TabIndex = 13;
            this.zipMaskedTextBox.ValidatingType = typeof(int);
            // 
            // zipLabel
            // 
            this.zipLabel.Location = new System.Drawing.Point(468, 96);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(35, 28);
            this.zipLabel.TabIndex = 12;
            this.zipLabel.Text = "Zip:";
            this.zipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stateLabel
            // 
            this.stateLabel.Location = new System.Drawing.Point(453, 60);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(49, 28);
            this.stateLabel.TabIndex = 10;
            this.stateLabel.Text = "State:";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(523, 28);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(95, 22);
            this.cityTextBox.TabIndex = 9;
            // 
            // cityLabel
            // 
            this.cityLabel.Location = new System.Drawing.Point(464, 26);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 28);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(173, 134);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(165, 22);
            this.streetTextBox.TabIndex = 7;
            // 
            // streetLabel
            // 
            this.streetLabel.Location = new System.Drawing.Point(104, 132);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(57, 28);
            this.streetLabel.TabIndex = 6;
            this.streetLabel.Text = "Street:";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(173, 98);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 22);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(65, 96);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 28);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(173, 63);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(145, 22);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(81, 60);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 28);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(119, 26);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(43, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Rev."});
            this.titleComboBox.Location = new System.Drawing.Point(173, 28);
            this.titleComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(68, 24);
            this.titleComboBox.TabIndex = 1;
            // 
            // deliveryInformationGroupBox
            // 
            this.deliveryInformationGroupBox.Controls.Add(this.homePriceLabel);
            this.deliveryInformationGroupBox.Controls.Add(this.homeRadioButton);
            this.deliveryInformationGroupBox.Controls.Add(this.storeRadioButton);
            this.deliveryInformationGroupBox.Controls.Add(this.deliveryTypeLabel);
            this.deliveryInformationGroupBox.Controls.Add(this.deliveryDateMaskedTextBox);
            this.deliveryInformationGroupBox.Controls.Add(this.deliveryDateLabel);
            this.deliveryInformationGroupBox.Location = new System.Drawing.Point(32, 311);
            this.deliveryInformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliveryInformationGroupBox.Name = "deliveryInformationGroupBox";
            this.deliveryInformationGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliveryInformationGroupBox.Size = new System.Drawing.Size(779, 95);
            this.deliveryInformationGroupBox.TabIndex = 3;
            this.deliveryInformationGroupBox.TabStop = false;
            this.deliveryInformationGroupBox.Text = "Delivery Information";
            // 
            // homePriceLabel
            // 
            this.homePriceLabel.Location = new System.Drawing.Point(716, 59);
            this.homePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.homePriceLabel.Name = "homePriceLabel";
            this.homePriceLabel.Size = new System.Drawing.Size(52, 28);
            this.homePriceLabel.TabIndex = 5;
            this.homePriceLabel.Text = "PRICE";
            this.homePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeRadioButton
            // 
            this.homeRadioButton.AutoSize = true;
            this.homeRadioButton.Location = new System.Drawing.Point(523, 63);
            this.homeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeRadioButton.Name = "homeRadioButton";
            this.homeRadioButton.Size = new System.Drawing.Size(121, 21);
            this.homeRadioButton.TabIndex = 4;
            this.homeRadioButton.Text = "Home Delivery";
            this.homeRadioButton.UseVisualStyleBackColor = true;
            // 
            // storeRadioButton
            // 
            this.storeRadioButton.AutoSize = true;
            this.storeRadioButton.Checked = true;
            this.storeRadioButton.Location = new System.Drawing.Point(523, 30);
            this.storeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storeRadioButton.Name = "storeRadioButton";
            this.storeRadioButton.Size = new System.Drawing.Size(116, 21);
            this.storeRadioButton.TabIndex = 3;
            this.storeRadioButton.TabStop = true;
            this.storeRadioButton.Text = "Store Pick-Up";
            this.storeRadioButton.UseVisualStyleBackColor = true;
            this.storeRadioButton.CheckedChanged += new System.EventHandler(this.storeRadioButton_CheckedChanged);
            // 
            // deliveryTypeLabel
            // 
            this.deliveryTypeLabel.Location = new System.Drawing.Point(399, 26);
            this.deliveryTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deliveryTypeLabel.Name = "deliveryTypeLabel";
            this.deliveryTypeLabel.Size = new System.Drawing.Size(104, 28);
            this.deliveryTypeLabel.TabIndex = 2;
            this.deliveryTypeLabel.Text = "Delivery Type:";
            this.deliveryTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deliveryDateMaskedTextBox
            // 
            this.deliveryDateMaskedTextBox.AllowDrop = true;
            this.deliveryDateMaskedTextBox.Location = new System.Drawing.Point(173, 28);
            this.deliveryDateMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliveryDateMaskedTextBox.Mask = "00/00/0000";
            this.deliveryDateMaskedTextBox.Name = "deliveryDateMaskedTextBox";
            this.deliveryDateMaskedTextBox.Size = new System.Drawing.Size(87, 22);
            this.deliveryDateMaskedTextBox.TabIndex = 1;
            this.deliveryDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Location = new System.Drawing.Point(57, 26);
            this.deliveryDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(104, 28);
            this.deliveryDateLabel.TabIndex = 0;
            this.deliveryDateLabel.Text = "Delivery Date:";
            this.deliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderDetailGroupBox
            // 
            this.orderDetailGroupBox.Controls.Add(this.perExtraLabel);
            this.orderDetailGroupBox.Controls.Add(this.messageTextBox);
            this.orderDetailGroupBox.Controls.Add(this.messageInstructionsLabel);
            this.orderDetailGroupBox.Controls.Add(this.messagePriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.messageCheckBox);
            this.orderDetailGroupBox.Controls.Add(this.extrasPriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.extrasListBox);
            this.orderDetailGroupBox.Controls.Add(this.extrasLabel);
            this.orderDetailGroupBox.Controls.Add(this.occasionComboBox);
            this.orderDetailGroupBox.Controls.Add(this.occasionLabel);
            this.orderDetailGroupBox.Controls.Add(this.dozenPriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.dozenRadioButton);
            this.orderDetailGroupBox.Controls.Add(this.halfDozenPriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.halfDozenRadioButton);
            this.orderDetailGroupBox.Controls.Add(this.singlePriceLabel);
            this.orderDetailGroupBox.Controls.Add(this.singleRadioButton);
            this.orderDetailGroupBox.Controls.Add(this.balloonSizeLabel);
            this.orderDetailGroupBox.Location = new System.Drawing.Point(32, 414);
            this.orderDetailGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderDetailGroupBox.Name = "orderDetailGroupBox";
            this.orderDetailGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderDetailGroupBox.Size = new System.Drawing.Size(779, 302);
            this.orderDetailGroupBox.TabIndex = 4;
            this.orderDetailGroupBox.TabStop = false;
            this.orderDetailGroupBox.Text = "Order Detail";
            // 
            // perExtraLabel
            // 
            this.perExtraLabel.Location = new System.Drawing.Point(359, 228);
            this.perExtraLabel.Name = "perExtraLabel";
            this.perExtraLabel.Size = new System.Drawing.Size(72, 23);
            this.perExtraLabel.TabIndex = 12;
            this.perExtraLabel.Text = "Per Extra";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(523, 98);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.MaxLength = 30;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(207, 22);
            this.messageTextBox.TabIndex = 16;
            // 
            // messageInstructionsLabel
            // 
            this.messageInstructionsLabel.Enabled = false;
            this.messageInstructionsLabel.Location = new System.Drawing.Point(501, 60);
            this.messageInstructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageInstructionsLabel.Name = "messageInstructionsLabel";
            this.messageInstructionsLabel.Size = new System.Drawing.Size(155, 28);
            this.messageInstructionsLabel.TabIndex = 15;
            this.messageInstructionsLabel.Text = "(30-Character Limit):";
            this.messageInstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // messagePriceLabel
            // 
            this.messagePriceLabel.Location = new System.Drawing.Point(716, 25);
            this.messagePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messagePriceLabel.Name = "messagePriceLabel";
            this.messagePriceLabel.Size = new System.Drawing.Size(52, 28);
            this.messagePriceLabel.TabIndex = 14;
            this.messagePriceLabel.Text = "PRICE";
            this.messagePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // messageCheckBox
            // 
            this.messageCheckBox.AutoSize = true;
            this.messageCheckBox.Location = new System.Drawing.Point(523, 30);
            this.messageCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageCheckBox.Name = "messageCheckBox";
            this.messageCheckBox.Size = new System.Drawing.Size(173, 21);
            this.messageCheckBox.TabIndex = 13;
            this.messageCheckBox.Text = "Personalized Message";
            this.messageCheckBox.UseVisualStyleBackColor = true;
            this.messageCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_CheckedChanged);
            // 
            // extrasPriceLabel
            // 
            this.extrasPriceLabel.Location = new System.Drawing.Point(356, 197);
            this.extrasPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.extrasPriceLabel.Name = "extrasPriceLabel";
            this.extrasPriceLabel.Size = new System.Drawing.Size(53, 28);
            this.extrasPriceLabel.TabIndex = 11;
            this.extrasPriceLabel.Text = "PRICE";
            this.extrasPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extrasListBox
            // 
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.ItemHeight = 16;
            this.extrasListBox.Location = new System.Drawing.Point(173, 202);
            this.extrasListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.Size = new System.Drawing.Size(145, 84);
            this.extrasListBox.TabIndex = 10;
            this.extrasListBox.SelectedIndexChanged += new System.EventHandler(this.extrasListBox_SelectedIndexChanged);
            // 
            // extrasLabel
            // 
            this.extrasLabel.Location = new System.Drawing.Point(108, 197);
            this.extrasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(53, 28);
            this.extrasLabel.TabIndex = 9;
            this.extrasLabel.Text = "Extras:";
            this.extrasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // occasionComboBox
            // 
            this.occasionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occasionComboBox.FormattingEnabled = true;
            this.occasionComboBox.Location = new System.Drawing.Point(173, 146);
            this.occasionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.occasionComboBox.Name = "occasionComboBox";
            this.occasionComboBox.Size = new System.Drawing.Size(145, 24);
            this.occasionComboBox.TabIndex = 8;
            // 
            // occasionLabel
            // 
            this.occasionLabel.Location = new System.Drawing.Point(31, 144);
            this.occasionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.occasionLabel.Name = "occasionLabel";
            this.occasionLabel.Size = new System.Drawing.Size(131, 28);
            this.occasionLabel.TabIndex = 7;
            this.occasionLabel.Text = "Special Occasion:";
            this.occasionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dozenPriceLabel
            // 
            this.dozenPriceLabel.AutoSize = true;
            this.dozenPriceLabel.Location = new System.Drawing.Point(359, 94);
            this.dozenPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dozenPriceLabel.Name = "dozenPriceLabel";
            this.dozenPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.dozenPriceLabel.TabIndex = 6;
            this.dozenPriceLabel.Text = "PRICE";
            this.dozenPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dozenRadioButton
            // 
            this.dozenRadioButton.AutoSize = true;
            this.dozenRadioButton.Location = new System.Drawing.Point(173, 98);
            this.dozenRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dozenRadioButton.Name = "dozenRadioButton";
            this.dozenRadioButton.Size = new System.Drawing.Size(70, 21);
            this.dozenRadioButton.TabIndex = 5;
            this.dozenRadioButton.Text = "Dozen";
            this.dozenRadioButton.UseVisualStyleBackColor = true;
            this.dozenRadioButton.CheckedChanged += new System.EventHandler(this.dozenRadioButton_CheckedChanged);
            // 
            // halfDozenPriceLabel
            // 
            this.halfDozenPriceLabel.AutoSize = true;
            this.halfDozenPriceLabel.Location = new System.Drawing.Point(359, 60);
            this.halfDozenPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.halfDozenPriceLabel.Name = "halfDozenPriceLabel";
            this.halfDozenPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.halfDozenPriceLabel.TabIndex = 4;
            this.halfDozenPriceLabel.Text = "PRICE";
            this.halfDozenPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // halfDozenRadioButton
            // 
            this.halfDozenRadioButton.AutoSize = true;
            this.halfDozenRadioButton.Location = new System.Drawing.Point(173, 64);
            this.halfDozenRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.halfDozenRadioButton.Name = "halfDozenRadioButton";
            this.halfDozenRadioButton.Size = new System.Drawing.Size(100, 21);
            this.halfDozenRadioButton.TabIndex = 3;
            this.halfDozenRadioButton.Text = "Half-Dozen";
            this.halfDozenRadioButton.UseVisualStyleBackColor = true;
            this.halfDozenRadioButton.CheckedChanged += new System.EventHandler(this.halfDozenRadioButton_CheckedChanged);
            // 
            // singlePriceLabel
            // 
            this.singlePriceLabel.AutoSize = true;
            this.singlePriceLabel.Location = new System.Drawing.Point(359, 26);
            this.singlePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.singlePriceLabel.Name = "singlePriceLabel";
            this.singlePriceLabel.Size = new System.Drawing.Size(48, 17);
            this.singlePriceLabel.TabIndex = 2;
            this.singlePriceLabel.Text = "PRICE";
            this.singlePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Checked = true;
            this.singleRadioButton.Location = new System.Drawing.Point(173, 30);
            this.singleRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(68, 21);
            this.singleRadioButton.TabIndex = 1;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // balloonSizeLabel
            // 
            this.balloonSizeLabel.Location = new System.Drawing.Point(19, 25);
            this.balloonSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balloonSizeLabel.Name = "balloonSizeLabel";
            this.balloonSizeLabel.Size = new System.Drawing.Size(143, 28);
            this.balloonSizeLabel.TabIndex = 0;
            this.balloonSizeLabel.Text = "Balloon Bundle Size:";
            this.balloonSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalsGroupBox
            // 
            this.orderTotalsGroupBox.Controls.Add(this.orderTotalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.orderTotalDescriptionLabel);
            this.orderTotalsGroupBox.Controls.Add(this.orderTotalDividerGroupBox);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxAmountLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subTotalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxAmountDescriptionLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subTotalDescriptionLabel);
            this.orderTotalsGroupBox.Location = new System.Drawing.Point(32, 724);
            this.orderTotalsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderTotalsGroupBox.Name = "orderTotalsGroupBox";
            this.orderTotalsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderTotalsGroupBox.Size = new System.Drawing.Size(779, 164);
            this.orderTotalsGroupBox.TabIndex = 5;
            this.orderTotalsGroupBox.TabStop = false;
            this.orderTotalsGroupBox.Text = "Order Totals";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTotalLabel.Location = new System.Drawing.Point(624, 122);
            this.orderTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(118, 28);
            this.orderTotalLabel.TabIndex = 6;
            this.orderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalDescriptionLabel
            // 
            this.orderTotalDescriptionLabel.Location = new System.Drawing.Point(499, 122);
            this.orderTotalDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTotalDescriptionLabel.Name = "orderTotalDescriptionLabel";
            this.orderTotalDescriptionLabel.Size = new System.Drawing.Size(92, 28);
            this.orderTotalDescriptionLabel.TabIndex = 5;
            this.orderTotalDescriptionLabel.Text = "Order Total:";
            this.orderTotalDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalDividerGroupBox
            // 
            this.orderTotalDividerGroupBox.BackColor = System.Drawing.Color.Black;
            this.orderTotalDividerGroupBox.Location = new System.Drawing.Point(623, 103);
            this.orderTotalDividerGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderTotalDividerGroupBox.Name = "orderTotalDividerGroupBox";
            this.orderTotalDividerGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderTotalDividerGroupBox.Size = new System.Drawing.Size(120, 4);
            this.orderTotalDividerGroupBox.TabIndex = 4;
            this.orderTotalDividerGroupBox.TabStop = false;
            // 
            // salesTaxAmountLabel
            // 
            this.salesTaxAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesTaxAmountLabel.Location = new System.Drawing.Point(624, 62);
            this.salesTaxAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesTaxAmountLabel.Name = "salesTaxAmountLabel";
            this.salesTaxAmountLabel.Size = new System.Drawing.Size(118, 28);
            this.salesTaxAmountLabel.TabIndex = 3;
            this.salesTaxAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTotalLabel.Location = new System.Drawing.Point(624, 18);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(118, 28);
            this.subTotalLabel.TabIndex = 1;
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxAmountDescriptionLabel
            // 
            this.salesTaxAmountDescriptionLabel.Location = new System.Drawing.Point(405, 62);
            this.salesTaxAmountDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesTaxAmountDescriptionLabel.Name = "salesTaxAmountDescriptionLabel";
            this.salesTaxAmountDescriptionLabel.Size = new System.Drawing.Size(188, 28);
            this.salesTaxAmountDescriptionLabel.TabIndex = 2;
            this.salesTaxAmountDescriptionLabel.Text = "Sales Tax Amount (7.00%):";
            this.salesTaxAmountDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalDescriptionLabel
            // 
            this.subTotalDescriptionLabel.Location = new System.Drawing.Point(519, 18);
            this.subTotalDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalDescriptionLabel.Name = "subTotalDescriptionLabel";
            this.subTotalDescriptionLabel.Size = new System.Drawing.Size(75, 28);
            this.subTotalDescriptionLabel.TabIndex = 0;
            this.subTotalDescriptionLabel.Text = "Subtotal:";
            this.subTotalDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displaySummaryButton
            // 
            this.displaySummaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displaySummaryButton.Location = new System.Drawing.Point(108, 908);
            this.displaySummaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displaySummaryButton.Name = "displaySummaryButton";
            this.displaySummaryButton.Size = new System.Drawing.Size(128, 28);
            this.displaySummaryButton.TabIndex = 6;
            this.displaySummaryButton.Text = "&Display Summary";
            this.buttonToolTip.SetToolTip(this.displaySummaryButton, "Click to display the order\'s summary");
            this.displaySummaryButton.UseVisualStyleBackColor = true;
            this.displaySummaryButton.Click += new System.EventHandler(this.displaySummaryButton_Click);
            // 
            // clearFormButton
            // 
            this.clearFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFormButton.Location = new System.Drawing.Point(357, 908);
            this.clearFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(128, 28);
            this.clearFormButton.TabIndex = 7;
            this.clearFormButton.Text = "Clea&r Form";
            this.buttonToolTip.SetToolTip(this.clearFormButton, "Click to reset the form");
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitProgramButton.Location = new System.Drawing.Point(609, 908);
            this.exitProgramButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(128, 28);
            this.exitProgramButton.TabIndex = 8;
            this.exitProgramButton.Text = "E&xit Program";
            this.buttonToolTip.SetToolTip(this.exitProgramButton, "Click to exit the order checkout");
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // balloonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(844, 958);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.displaySummaryButton);
            this.Controls.Add(this.orderTotalsGroupBox);
            this.Controls.Add(this.orderDetailGroupBox);
            this.Controls.Add(this.deliveryInformationGroupBox);
            this.Controls.Add(this.customerInformationGroupBox);
            this.Controls.Add(this.balloonLabel);
            this.Controls.Add(this.balloonPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "balloonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonnie\'s Balloons Order CheckOut";
            this.Load += new System.EventHandler(this.balloonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).EndInit();
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            this.deliveryInformationGroupBox.ResumeLayout(false);
            this.deliveryInformationGroupBox.PerformLayout();
            this.orderDetailGroupBox.ResumeLayout(false);
            this.orderDetailGroupBox.PerformLayout();
            this.orderTotalsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox balloonPictureBox;
        private System.Windows.Forms.Label balloonLabel;
        private System.Windows.Forms.GroupBox customerInformationGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.MaskedTextBox zipMaskedTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.GroupBox deliveryInformationGroupBox;
        private System.Windows.Forms.MaskedTextBox deliveryDateMaskedTextBox;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.RadioButton homeRadioButton;
        private System.Windows.Forms.RadioButton storeRadioButton;
        private System.Windows.Forms.Label deliveryTypeLabel;
        private System.Windows.Forms.Label homePriceLabel;
        private System.Windows.Forms.GroupBox orderDetailGroupBox;
        private System.Windows.Forms.Label balloonSizeLabel;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.Label occasionLabel;
        private System.Windows.Forms.Label dozenPriceLabel;
        private System.Windows.Forms.RadioButton dozenRadioButton;
        private System.Windows.Forms.Label halfDozenPriceLabel;
        private System.Windows.Forms.RadioButton halfDozenRadioButton;
        private System.Windows.Forms.Label singlePriceLabel;
        private System.Windows.Forms.ComboBox occasionComboBox;
        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.ListBox extrasListBox;
        private System.Windows.Forms.Label extrasPriceLabel;
        private System.Windows.Forms.CheckBox messageCheckBox;
        private System.Windows.Forms.Label messagePriceLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label messageInstructionsLabel;
        private System.Windows.Forms.GroupBox orderTotalsGroupBox;
        private System.Windows.Forms.Label salesTaxAmountDescriptionLabel;
        private System.Windows.Forms.Label subTotalDescriptionLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label salesTaxAmountLabel;
        private System.Windows.Forms.GroupBox orderTotalDividerGroupBox;
        private System.Windows.Forms.Label orderTotalDescriptionLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Button displaySummaryButton;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.ToolTip buttonToolTip;
        private System.Windows.Forms.MaskedTextBox stateMaskedTextBox;
        private System.Windows.Forms.Label perExtraLabel;
    }
}

