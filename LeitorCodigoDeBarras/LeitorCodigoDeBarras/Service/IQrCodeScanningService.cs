using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeitorCodigoDeBarras.Service
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
