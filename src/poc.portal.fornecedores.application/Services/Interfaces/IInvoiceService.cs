using poc.portal.fornecedores.application.Models.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace poc.portal.fornecedores.application.Services.Interfaces
{
    public interface IInvoiceService
    {
        Task<string> AddInvoiceAsync(XmlRequest invoiceXml, CancellationToken cancellationToken);
    }
}