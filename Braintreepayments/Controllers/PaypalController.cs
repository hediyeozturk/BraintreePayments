using Braintree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Braintreepayments.Controllers
{
    public class PaypalController : Controller
    {
        // GET: Paypal
        [HttpGet]
        public ActionResult CreateMerchant()
        {
            //var request = new AddressRequest
            //{
            //    FirstName = "Jenna",
            //    LastName = "Smith",
            //    Company = "Braintree",
            //    StreetAddress = "1 E Main St",
            //    ExtendedAddress = "Suite 403",
            //    Locality = "Chicago",
            //    Region = "Illinois",
            //    PostalCode = "60622",
            //    CountryCodeAlpha2 = "US"
            //};
            BraintreeGateway gateway = new BraintreeGateway(
                Braintree.Environment.SANDBOX,
                "2jy7ybdh4h7j4dtc",
                "ks38q8k5b8637njx",
                "e9bcaf74b68c95e35d4d92b339801d5b"
             );

            MerchantAccountRequest request = new MerchantAccountRequest
            {
                Individual = new IndividualRequest
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "jane@14ladders.com",
                    Phone = "5553334444",
                    DateOfBirth = "1981-11-19",
                    Ssn = "456-45-4567",
                    Address = new AddressRequest
                    {
                        StreetAddress = "111 Main St",
                        Locality = "Chicago",
                        Region = "IL",
                        PostalCode = "60622"
                    }
                },
                Business = new BusinessRequest
                {
                    LegalName = "Jane's Ladders",
                    DbaName = "Jane's Ladders",
                    TaxId = "98-7654321",
                    Address = new AddressRequest
                    {
                        StreetAddress = "111 Main St",
                        Locality = "Chicago",
                        Region = "IL",
                        PostalCode = "60622"
                    }
                },
                Funding = new FundingRequest
                {
                    Descriptor = "Blue Ladders",
                    Destination = FundingDestination.BANK,
                    Email = "funding@blueladders.com",
                    MobilePhone = "5555555555",
                    AccountNumber = "1123581321",
                    RoutingNumber = "071101307"
                },
                TosAccepted = true,
                MasterMerchantAccountId = "14ladders_marketplace",
                Id = "blue_ladders_store"
            };

            Result<MerchantAccount> result = gateway.MerchantAccount.Create(request);
            //TransactionCreditCardRequest creditCardRequest = new TransactionCreditCardRequest();
            //creditCardRequest.CardholderName = "Ahmet Mehmet";
            //creditCardRequest.Number = "4444-5555-6666-7777";
            //creditCardRequest.ExpirationDate = "04/21";
            //creditCardRequest.CVV = "233";


            //TransactionOptionsRequest optionsRequest = new TransactionOptionsRequest();
            //optionsRequest.SubmitForSettlement = true;

            if (result.IsSuccess())
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("google.com");
        }

        
       public ActionResult CreateCustomer()
        {
            return View();
        }
        public ActionResult CreatePaymentMethod()
        {
            return View();
        }
    }
}