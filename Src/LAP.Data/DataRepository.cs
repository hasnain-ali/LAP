using LAP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Data
{
    public class DataRepository
    {
        public static IList<Loan> GetAllLoans()
        {
            var loans = new List<Loan>();

            var natwestLoan = new Loan();
            natwestLoan.LoanId = 1;
            natwestLoan.LoanProvider = LoanProviders.Natwest;
            natwestLoan.LoanPurposes.Add(LoanPurpose.Car);
            natwestLoan.LoanPurposes.Add(LoanPurpose.Debts);
            natwestLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            natwestLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            natwestLoan.LoanPurposes.Add(LoanPurpose.SomethingElse);
            natwestLoan.LoanPurposes.Add(LoanPurpose.Wedding);
            natwestLoan.MinAmount = 1000;
            natwestLoan.MaxAmount = 10000;
            natwestLoan.MinTermYears = 1;
            natwestLoan.MaxTermYears = 5;
            natwestLoan.MinCreditScore = 600;
            natwestLoan.MaxCreditScore = 800;
            natwestLoan.CreditScoreProviders.Add(CreditScoreProviders.Experian);
            natwestLoan.CreditScoreProviders.Add(CreditScoreProviders.Equifax);
            natwestLoan.RepresentativeApr = 3.4M;
            loans.Add(natwestLoan);

            var rbsLoan = new Loan();
            rbsLoan.LoanId = 2;
            rbsLoan.LoanProvider = LoanProviders.RBS;
            rbsLoan.LoanPurposes.Add(LoanPurpose.Car);
            //rbsLoan.LoanPurposes.Add(LoanPurpose.Debts);
            rbsLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            rbsLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            //rbsLoan.LoanPurposes.Add(LoanPurpose.SomethingElse);
            rbsLoan.LoanPurposes.Add(LoanPurpose.Wedding);
            rbsLoan.MinAmount = 1000;
            rbsLoan.MaxAmount = 7000;
            rbsLoan.MinTermYears = 1;
            rbsLoan.MaxTermYears = 5;
            rbsLoan.MinCreditScore = 400;
            rbsLoan.MaxCreditScore = 700;
            rbsLoan.CreditScoreProviders.Add(CreditScoreProviders.Experian);
            rbsLoan.RepresentativeApr = 4.2M;
            loans.Add(rbsLoan);

            var nationwideLoan = new Loan();
            nationwideLoan.LoanId = 3;
            nationwideLoan.LoanProvider = LoanProviders.Nationwide;
            nationwideLoan.LoanPurposes.Add(LoanPurpose.Car);
            nationwideLoan.LoanPurposes.Add(LoanPurpose.Debts);
            nationwideLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            nationwideLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            nationwideLoan.LoanPurposes.Add(LoanPurpose.Wedding);
            nationwideLoan.MinAmount = 1000;
            nationwideLoan.MaxAmount = 10000;
            nationwideLoan.MinTermYears = 1;
            nationwideLoan.MaxTermYears = 3;
            nationwideLoan.MinCreditScore = 300;
            nationwideLoan.MaxCreditScore = 500;
            nationwideLoan.CreditScoreProviders.Add(CreditScoreProviders.Equifax);
            nationwideLoan.RepresentativeApr = 5.3M;
            loans.Add(nationwideLoan);

            var santanderLoan = new Loan();
            santanderLoan.LoanId = 4;
            santanderLoan.LoanProvider = LoanProviders.Santander;
            santanderLoan.LoanPurposes.Add(LoanPurpose.Car);
            santanderLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            santanderLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            santanderLoan.LoanPurposes.Add(LoanPurpose.SomethingElse);
            santanderLoan.MinAmount = 1000;
            santanderLoan.MaxAmount = 5000;
            santanderLoan.MinTermYears = 1;
            santanderLoan.MaxTermYears = 5;
            santanderLoan.MinCreditScore = 200;
            santanderLoan.MaxCreditScore = 900;
            santanderLoan.CreditScoreProviders.Add(CreditScoreProviders.Experian);
            santanderLoan.CreditScoreProviders.Add(CreditScoreProviders.Equifax);
            santanderLoan.RepresentativeApr = 6.2M;
            loans.Add(santanderLoan);

            var sainsburysBankLoan = new Loan();
            sainsburysBankLoan.LoanId = 5;
            sainsburysBankLoan.LoanProvider = LoanProviders.SainsburysBank;
            sainsburysBankLoan.LoanPurposes.Add(LoanPurpose.Car);
            sainsburysBankLoan.LoanPurposes.Add(LoanPurpose.Debts);
            sainsburysBankLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            sainsburysBankLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            sainsburysBankLoan.LoanPurposes.Add(LoanPurpose.SomethingElse);
            sainsburysBankLoan.LoanPurposes.Add(LoanPurpose.Wedding);
            sainsburysBankLoan.MinAmount = 3000;
            sainsburysBankLoan.MaxAmount = 10000;
            sainsburysBankLoan.MinTermYears = 1;
            sainsburysBankLoan.MaxTermYears = 5;
            sainsburysBankLoan.MinCreditScore = 300;
            sainsburysBankLoan.MaxCreditScore = 800;
            sainsburysBankLoan.CreditScoreProviders.Add(CreditScoreProviders.Experian);
            sainsburysBankLoan.CreditScoreProviders.Add(CreditScoreProviders.Equifax);
            sainsburysBankLoan.RepresentativeApr = 7.8M;
            loans.Add(sainsburysBankLoan);

            var tescoBankLoan = new Loan();
            tescoBankLoan.LoanId = 6;
            tescoBankLoan.LoanProvider = LoanProviders.TescoBank;
            tescoBankLoan.LoanPurposes.Add(LoanPurpose.Car);
            tescoBankLoan.LoanPurposes.Add(LoanPurpose.Debts);
            tescoBankLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            tescoBankLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            tescoBankLoan.LoanPurposes.Add(LoanPurpose.SomethingElse);
            tescoBankLoan.LoanPurposes.Add(LoanPurpose.Wedding);
            tescoBankLoan.MinAmount = 1000;
            tescoBankLoan.MaxAmount = 10000;
            tescoBankLoan.MinTermYears = 1;
            tescoBankLoan.MaxTermYears = 5;
            tescoBankLoan.MinCreditScore = 100;
            tescoBankLoan.MaxCreditScore = 900;
            tescoBankLoan.CreditScoreProviders.Add(CreditScoreProviders.Experian);
            tescoBankLoan.CreditScoreProviders.Add(CreditScoreProviders.Equifax);
            tescoBankLoan.RepresentativeApr = 2.2M;
            loans.Add(tescoBankLoan);

            var MandSBankLoan = new Loan();
            MandSBankLoan.LoanId = 7;
            MandSBankLoan.LoanProvider = LoanProviders.MAndSBank;
            MandSBankLoan.LoanPurposes.Add(LoanPurpose.Car);
            MandSBankLoan.LoanPurposes.Add(LoanPurpose.Debts);
            MandSBankLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            MandSBankLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            MandSBankLoan.LoanPurposes.Add(LoanPurpose.Wedding);
            MandSBankLoan.MinAmount = 1000;
            MandSBankLoan.MaxAmount = 10000;
            MandSBankLoan.MinTermYears = 1;
            MandSBankLoan.MaxTermYears = 5;
            MandSBankLoan.MinCreditScore = 200;
            MandSBankLoan.MaxCreditScore = 900;
            MandSBankLoan.CreditScoreProviders.Add(CreditScoreProviders.Experian);
            MandSBankLoan.CreditScoreProviders.Add(CreditScoreProviders.Equifax);
            MandSBankLoan.RepresentativeApr = 8.2M;
            loans.Add(MandSBankLoan);

            return loans;
        }

        #region Mocked Data for Demo

        private static class LoanProviders
        {
            public static LoanProvider Natwest
            {
                get
                {
                    return new LoanProvider()
                    {
                        Id = "Natwest",
                        Name = "Natwest",
                        LogoFile = "Natwest"
                    };
                }
            }

            public static LoanProvider Nationwide
            {
                get
                {
                    return new LoanProvider()
                    {
                        Id = "Nationwide",
                        Name = "Nationwide",
                        LogoFile = "Nationwide"
                    };
                }
            }

            public static LoanProvider RBS
            {
                get
                {
                    return new LoanProvider()
                    {
                        Id = "RBS",
                        Name = "Royal Bank of Scotland",
                        LogoFile = "RBS"
                    };
                }
            }

            public static LoanProvider Santander
            {
                get
                {
                    return new LoanProvider()
                    {
                        Id = "Santander",
                        Name = "Santander",
                        LogoFile = "Santander"
                    };
                }
            }

            public static LoanProvider SainsburysBank
            {
                get
                {
                    return new LoanProvider()
                    {
                        Id = "SainsburysBank",
                        Name = "Sainsbury's Bank",
                        LogoFile = "SainsburysBank"
                    };
                }
            }
            public static LoanProvider TescoBank
            {
                get
                {
                    return new LoanProvider()
                    {
                        Id = "TescoBank",
                        Name = "Tesco Bank",
                        LogoFile = "TescoBank"
                    };
                }
            }

            public static LoanProvider MAndSBank
            {
                get
                {
                    return new LoanProvider()
                    {
                        Id = "MAndSBank",
                        Name = "M&S Bank",
                        LogoFile = "MAndSBank"
                    };
                }
            }
        }

        private static class CreditScoreProviders
        {
            public static CreditScoreProvider Experian
            {
                get
                {
                    return new CreditScoreProvider()
                    {
                        Id = "Experian",
                        Name = "Experian"
                    };
                }
            }

            public static CreditScoreProvider Equifax
            {
                get
                {
                    return new CreditScoreProvider()
                    {
                        Id = "Equifax",
                        Name = "Equifax"
                    };
                }
            }
        }

        #endregion
    }
}
