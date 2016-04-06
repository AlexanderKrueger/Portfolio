using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    //---Variables---
    private static double MonthlyPayment = 0;
    private static double InitialPrincipalBalance = 0;
    private static double PrincipalBalance = 0;
    private static double AnnualInterestPayRate = 0;
    private static double MonthlyInterestPaidDown = 0;
    private static double PrincipalPaidDown = 0;
    private static int Term = 0;//Term should be inputed as months

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //confirm all text fields are filled, then proceeds if true
            if (!(TextBoxPrincipalBalance.Text.Equals("")
                || TextBoxTerm.Text.Equals("")
                || TextBoxAnnualPayRate.Text.Equals("")))
            {
                //---Table Objects (prepped for printing table rows)---
                TableCell CellPaymentNumber = new TableCell();
                TableCell CellMonthlyInterest = new TableCell();
                TableCell CellPrincipalPaidDown = new TableCell();
                TableCell CellPrincipalBalance = new TableCell();
                TableRow tempRow = new TableRow();
            }
        }
    }


    protected void ButtonCalculate_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            //confirm all text fields are filled, then proceeds if true. conditions
            //are required since variable 'IsValid' is true when text fields are empty
            if (!(TextBoxPrincipalBalance.Text.Equals("")
                || TextBoxTerm.Text.Equals("")
                || TextBoxAnnualPayRate.Text.Equals("")))
            {
                //---Variables---
                PrincipalBalance = Convert.ToDouble(TextBoxPrincipalBalance.Text); 
                //Below variable's value should not be changed.
                InitialPrincipalBalance = Convert.ToDouble(TextBoxPrincipalBalance.Text);
                AnnualInterestPayRate = Convert.ToDouble(TextBoxAnnualPayRate.Text);
                MonthlyInterestPaidDown = 0;
                PrincipalPaidDown = 0;
                Term = Convert.ToInt32(TextBoxTerm.Text);

                //---Table Objects(prepped for printing table rows)---
                TableCell FooterCellPaymentNumber = new TableCell();
                TableCell FooterCellMonthlyInterest = new TableCell();
                TableCell FooterCellPrincipalPaidDown = new TableCell();
                TableCell FooterCellPrincipalBalance = new TableCell(); //term in alg mus go to months & field given same wrong number every time

                //if table is larger than 1 header and 1 footer row, prepare Amortization table
                //for new results
                if (AmortizationTable.Rows.Count > 2)
                {
                    EmptyTable(AmortizationTable);
                }

                //Get Constant 'MonthlyPayment'
                CalcMonthlyPayment();
                TextBoxMonthlyPayment.Text = MonthlyPayment.ToString("n2");

                //print table rows
                for (int i = 1; i <= Term; i++)
                {
                    //---Table Objects---
                    TableRow newRow = new TableRow();
                    TableCell CellPaymentNumber = new TableCell();
                    TableCell CellMonthlyInterest = new TableCell();
                    TableCell CellPrincipalPaidDown = new TableCell();
                    TableCell CellPrincipalBalance = new TableCell();

                    //---Math Work---
                    CellPaymentNumber.Text = i.ToString();

                    MonthlyInterestPaidDown = getMonthlyInterestPaidDown();//APR is cash not percent(decimal form)
                    CellMonthlyInterest.Text = MonthlyInterestPaidDown.ToString("n2");

                    PrincipalPaidDown = getPrincipalPaidDown();
                    CellPrincipalPaidDown.Text = PrincipalPaidDown.ToString("n2");

                    /*setNewPrincipalBalance*/
                    PrincipalBalance = getNewPrincipalBalance();
                    CellPrincipalBalance.Text = PrincipalBalance.ToString("n2");

                    //prevents unneeded rows from printing
                    if (PrincipalBalance < 0) { goto loopExit; }

                    //prints cells for row
                    newRow.Cells.AddRange(new TableCell[]
                        {
                            CellPaymentNumber,
                            CellMonthlyInterest,
                            CellPrincipalPaidDown,
                            CellPrincipalBalance
                        });

                    //places new rows in correct order
                    AmortizationTable.Rows.AddAt(AmortizationTable.Rows.Count - 1, newRow);
                }
            /*==Label==*/loopExit:

                //turns a negative value in final payment row to 0 since this is the
                //real world, and as such people can't pay more than what they owe to the bank
                if (PrincipalBalance < 0) { PrincipalBalance = 0; }


                FooterFinalPaymentValue.Text = "Final Payment: " + PrincipalPaidDown.ToString("n2");
                myTableFooter.Cells.AddAt(2, FooterFinalPaymentValue);
                myTableFooter.Cells[0].Text = "";
            }
        }
    }

    private double getMonthlyInterestPaidDown()
    {
        return (PrincipalBalance * (/*convert to decimal & years to months*/AnnualInterestPayRate / 100 / 12));
    }

    private void CalcMonthlyPayment()
    {
        double MonthlyInterestRate = AnnualInterestPayRate / 100 / 12;
        MonthlyPayment = (MonthlyInterestRate * InitialPrincipalBalance) / ( 1 - Math.Pow((1 + MonthlyInterestRate), -Term) );
    }

    private double getPrincipalPaidDown()
    {
        return MonthlyPayment - MonthlyInterestPaidDown;
    }

    private double getNewPrincipalBalance()
    {
        return PrincipalBalance - PrincipalPaidDown;
    }

    private void EmptyTable(Table table)
    {
       //REM: for reference only
       //int startingIndex = 1;
         int stoppingIndex = table.Rows.Count - 2;

         for(int i = /*startingIndex*/ 1; i < stoppingIndex; i++)
         {
            table.Rows.RemoveAt(i);
         }
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxPrincipalBalance.Text = "";
        TextBoxAnnualPayRate.Text = "";
        TextBoxTerm.Text = "";
        TextBoxMonthlyPayment.Text = "";

        EmptyTable(AmortizationTable);
    }
}
