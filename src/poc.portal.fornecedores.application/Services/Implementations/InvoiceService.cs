using poc.portal.fornecedores.application.Models.Requests;
using poc.portal.fornecedores.application.Services.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace poc.portal.fornecedores.application.Services.Implementations
{
    public class InvoiceService : IInvoiceService
    {
        public async Task<string> AddInvoiceAsync(
            XmlRequest invoiceXml, 
            CancellationToken cancellationToken)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.LoadXml(invoiceXml.Xml);
            }
            catch (XmlException ex)
            {
                throw new XmlException("XML syntax error", ex);
            }



            return invoiceXml.Xml;
        }
    }
}
