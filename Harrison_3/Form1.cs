// Programmer: Brennan Harrison
// Project: Harrison_3
// Date: 10/26/2018
// Description: Individual Assignment #3

using System;
using System.Windows.Forms;
using System.IO;

namespace Harrison_3
{
    public partial class balloonForm : Form
    {
        public balloonForm()
        {
            InitializeComponent();
        }

        // Constant fields.
        private const decimal HOME_DELIVERY_PRICE = 7.50m;       // Price for a home delivery type.
        private const decimal SINGLE_BALLOON_PRICE = 9.95m;      // Price for a single balloon bundle.
        private const decimal HALF_DOZEN_BALLOON_PRICE = 35.95m; // Price for a half-dozen balloon bundle.
        private const decimal DOZEN_BALLOON_PRICE = 65.95m;      // Price for a dozen balloon bundle.
        private const decimal EXTRAS_PRICE = 9.50m;              // Price for selecting extras (additional cost).
        private const decimal STANDARD_MESSAGE_PRICE = 2.50m;    // Price for a personalized message.
        private const decimal SALES_TAX_RATE = 0.07m;            // Sales tax rate.

        // Declared fields. 
        private string deliveryType;        // Hold the selected delivery type.
        private decimal deliveryPrice;      // Hold the delivery price.
        private string balloonBundleSize;   // Hold the selected balloon bundle size.
        private decimal balloonBundlePrice; // Hold the balloon bundle price.
        private string occasion;            // Hold the selected occasion. 
        private string extrasList;          // Hold a list of all selected extras.
        private int extrasCount;            // Hold the number of selected extras.
        private decimal extrasTotalPrice;   // Total cost for all selected extras.
        private decimal messagePrice;       // Cost for including (or not including) a message.
        private decimal subTotal;           // Cost of subtotal.
        private decimal salesTaxAmount;     // Tax amount on the subtotal.
        private decimal orderTotal;         // Cost of the subtotal and the tax amount.

        // Form load event handler.
        private void balloonForm_Load(object sender, System.EventArgs e)
        {
            // Load the current date in the deliveryDateMaskedTextBox control.
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            
            // Load the prices for each service in their appropriate labels.
            homePriceLabel.Text = HOME_DELIVERY_PRICE.ToString("c");
            singlePriceLabel.Text = SINGLE_BALLOON_PRICE.ToString("c");
            halfDozenPriceLabel.Text = HALF_DOZEN_BALLOON_PRICE.ToString("c");
            dozenPriceLabel.Text = DOZEN_BALLOON_PRICE.ToString("c");
            extrasPriceLabel.Text = EXTRAS_PRICE.ToString("c");
            messagePriceLabel.Text = STANDARD_MESSAGE_PRICE.ToString("c");

            // Call the PopulateBoxes() method.
            PopulateBoxes();

            // Call the UpdateTotals() method.
            UpdateTotals();

            /* Sort the items in the occassionComboBox control.
             * Auto select the second item in the occassionComboBox control. */
            occasionComboBox.Sorted = true;
            occasionComboBox.SelectedIndex = 1;

            /* Sort the items in the extrasListBox control.
             * Let the user select more than one item in the extrasListBox control. */
            extrasListBox.Sorted = true;
            extrasListBox.SelectionMode = SelectionMode.MultiSimple;
        }

        // Custom PopulateBoxes() method.
        private void PopulateBoxes()
        {
            // Try block.
            try
            {
                /* Create a file object for reading data from a file.
                 * Clear any possible items in the occasionComboBox control.
                 * Open a file called "Occasions".
                 * Using a while loop, if the data from the beginning to the end of the file has not been read then:
                 * Add the data from the file as items to the occassionComboBox control. 
                 * Close the file. */
                StreamReader inputFile;
                occasionComboBox.Items.Clear();
                inputFile = File.OpenText("Occasions.txt");
                while (!inputFile.EndOfStream)
                {
                    occasionComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            // Catch block.
            catch (Exception ex)
            {
                // Display the default error message if there was a problem reading data from the file.
                MessageBox.Show(ex.Message);
            }

            // Try block.
            try
            {
                /* Create a file object for reading data from a file.
                 * Clear any possible items in the extrasListBox control.
                 * Open a file called "Extras".
                 * Using a while loop, if the data from the beginning to the end of the file has not been read then:
                 * Add the data from the file as items to the extrasListBox control. 
                 * Close the file. */
                StreamReader inputFile;
                extrasListBox.Items.Clear();
                inputFile = File.OpenText("Extras.txt");
                while (!inputFile.EndOfStream)
                {
                    extrasListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            // Catch block
            catch (Exception ex)
            {
                // Display the default error message if there was a problem reading data from the file.
                MessageBox.Show(ex.Message);
            }
        }

        // Custom UpdateTotals() method.
        private void UpdateTotals()
        {
            // Reset each variable every time the UpdateTotals() method is called.
            extrasList = "";
            extrasCount = 0;
            extrasTotalPrice = 0.00m;
            subTotal = 0.00m;
            salesTaxAmount = 0.00m;
            orderTotal = 0.00m;

            // If the homeRdioButton control is checked then:
            if (homeRadioButton.Checked)
            {
                /* Assign the deliveryType variable with "Home".
                 * Assign the deliveryPrice variable with HOME_DELIVERY_PRICE. */
                deliveryType = "Home";
                deliveryPrice = HOME_DELIVERY_PRICE;
            }
            // Otherwise:
            else
            {
                /* Assign the deliveryType variable with "Store Pick-Up".
                 * Assign the deliveryPrice variable with 0.00. */
                deliveryType = "Store Pick-Up";
                deliveryPrice = 0.00m;
            }

            // If the halfDozenRadioButton is checked then:
            if (halfDozenRadioButton.Checked)
            {
                /* Assign the balloonBundleSize variable with "Half-Dozen".
                 * Assign the balloonBundlePrice variable with HALF_DOZEN_BALLOON_PRICE. */
                balloonBundleSize = "Half-Dozen";
                balloonBundlePrice = HALF_DOZEN_BALLOON_PRICE;
            }
            // Otherwise, if the dozenRadioButton control is checked then:
            else if (dozenRadioButton.Checked)
            {
                /* Assign the balloonBundleSize variable with "Dozen".
                 * Assign the balloonBundlePrice variable with DOZEN_BALLOON_PRICE. */
                balloonBundleSize = "Dozen";
                balloonBundlePrice = DOZEN_BALLOON_PRICE;
            }
            // Otherwise:
            else
            {
                /* Assign the balloonBundleSize variable with "Single".
                 * Assign the balloonBundlePrice with SINGLE_BALLOON_PRICE. */
                balloonBundleSize = "Single";
                balloonBundlePrice = SINGLE_BALLOON_PRICE;
            }

            // Loop through all items in the extrasListBox control and count how many were selected.
            for (int counter = 0; counter < extrasListBox.Items.Count; counter++)
            {
                // Determine if list box item is selected or not.
                if (extrasListBox.GetSelected(counter))
                {
                    // Increment and assign the items selected in the extrasListBox control with the 
                    // extrasList variable and concatenate each selected item on a new line.
                    extrasList += extrasListBox.Items[counter] + "\n";
                    extrasCount++; // Increment the extrasCount variable every time an item is selected.
                }
            }

            // Calculate the extrasTotalPrice variable.
            extrasTotalPrice = extrasCount * EXTRAS_PRICE;

            // If the messageCheckBox control is checked then:
            if (messageCheckBox.Checked)
            {
                /* Assign the messagePrice variable with STANDARD_MESSAGE_PRICE.
                 * Clear the messageTextBox control's text property.
                 * Enable the messageInstructionsLabel control.
                 * Enable the messageTextBox control property.
                 * Give the focus to the messageTextBox control. */
                messagePrice = STANDARD_MESSAGE_PRICE;
                messageTextBox.Text = "";
                messageInstructionsLabel.Enabled = true;
                messageTextBox.Enabled = true;
                messageTextBox.Focus();
            }
            // Otherwise: 
            else
            {
                /* Assign the messagePrice variable with 0.00.
                 * Clear the messageTextBox control's text property.
                 * Disable the messageInstructionsLabel control.
                 * Disable the messageTextBox control. */
                messagePrice = 0.00m;
                messageTextBox.Text = "";
                messageInstructionsLabel.Enabled = false;
                messageTextBox.Enabled = false;
            }

            /* Calculate the subTotal variable.
             * Display the subTotal variable. */
            subTotal = deliveryPrice + balloonBundlePrice + extrasTotalPrice + messagePrice;
            subTotalLabel.Text = subTotal.ToString("c");

            /* Calculate the salesTaxAmount variable.
             * Display the salesTaxAmount variable. */
            salesTaxAmount = subTotal * SALES_TAX_RATE;
            salesTaxAmountLabel.Text = salesTaxAmount.ToString("c");

            /* Calculate the orderTotal variable.
             * Display the orderTotal variable. */
            orderTotal = subTotal + salesTaxAmount;
            orderTotalLabel.Text = orderTotal.ToString("c");
        }
        
        // storeRadioButton checked changed event handler.
        private void storeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time the storeRadioButton is checked.
            UpdateTotals();
        }

        // halfDozenRadioButton checked changed event handler.
        private void halfDozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time the halfDozenRadioButton is checked.
            UpdateTotals();
        }

        // dozenRadioButton checked changed event handler.
        private void dozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time the dozenRadioButton is checked.
            UpdateTotals();
        }

        // messageCheckBox checked changed event handler.
        private void messageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time the messageCheckBox is checked.
            UpdateTotals();
        }
        
        // extrasListBox selected index changed event handler.
        private void extrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the UpdateTotals() method every time an item is selected in the extrasListBox control.
            UpdateTotals();
        }

        // displaySummaryButton click event handler.
        private void displaySummaryButton_Click(object sender, EventArgs e)
        {
            // If an item is selected in the occasionComboBox control then:
            if (occasionComboBox.SelectedIndex != -1)
            {
                // Get the currently selected item and assign it to the occasion variable.
                occasion = occasionComboBox.SelectedItem.ToString();
            }

            // If the user's full name is not entered or their phone number is incomplete then:
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || !phoneNumberMaskedTextBox.MaskFull)
            {
                // Display a message box asking for their information.
                MessageBox.Show("Please enter your full name and complete phone number before displaying the summary.",
                                "Insufficient Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Otherwise:
            else
            {
                // Display a message box showing the customer's complete order summary.
                MessageBox.Show("BONNIE'S BALLOONS ORDER SUMMARY\n\n" +
                                "Customer Name: " + titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                                "Customer Address: " + streetTextBox.Text + ", " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text + "\n" +
                                "Customer Phone: " + phoneNumberMaskedTextBox.Text + "\n" +
                                "Delivery Date: " + deliveryDateMaskedTextBox.Text + "\n" +
                                "Delivery Type: " + deliveryType + "\n" +
                                "Bundle Size: " + balloonBundleSize + "\n" +
                                "Occasion: " + occasion + "\n" +
                                "\nExtras:\n" + extrasList +
                                "\nPersonalized Message: " + messageTextBox.Text + "\n" +
                                "Order Subtotal: " + subTotal.ToString("c") + "\n" +
                                "Sales Tax Amount: " + salesTaxAmount.ToString("c") + "\n" +
                                "Order Total: " + orderTotal.ToString("c"),
                                "Checkout Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Call the ResetForm() method after displaying the customer's order summary.
            ResetForm();
        }

        // Custom ResetForm() method.
        private void ResetForm()
        {
            // Reset the form to its original appearance.
            titleComboBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateMaskedTextBox.Text = "";
            zipMaskedTextBox.Text = "";
            phoneNumberMaskedTextBox.Text = "";
            storeRadioButton.Checked = true;
            singleRadioButton.Checked = true;
            occasionComboBox.SelectedIndex = 1;
            extrasListBox.ClearSelected();
            messageCheckBox.Checked = false;

            // Give the focus to the titleComboBox control.
            titleComboBox.Focus();
        }

        // clearFormButton click event handler.
        private void clearFormButton_Click(object sender, EventArgs e)
        {
            // Call the ResetForm() method when the clearFormButton is clicked.
            ResetForm();
        }

        // exitProgramButton click event handler.
        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            // Declare a variable to hold user selection in dialog box.
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to exit the order checkout?",
                                       "Exit Order Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Take appropriate action based on user selection in dialog box.
            if (selection == DialogResult.Yes)
            {
                // Close the form (ending the program).
                this.Close();
            }
        }
    }
}
