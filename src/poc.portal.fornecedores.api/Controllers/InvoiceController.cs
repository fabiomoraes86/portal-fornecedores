using Microsoft.AspNetCore.Mvc;
using poc.portal.fornecedores.application.Models.Requests;
using poc.portal.fornecedores.application.Services.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace poc.portal.fornecedores.api.Controllers
{
    [ApiController]
    [Route("/v1")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public async Task<IActionResult> AddInvoiceAsync(
            XmlRequest invoiceXml, 
            CancellationToken cancellationToken)
        {
            await _invoiceService.AddInvoiceAsync(invoiceXml, cancellationToken);

            return Ok("OK");
        }

        //Get All



        //Delete
    }
}
