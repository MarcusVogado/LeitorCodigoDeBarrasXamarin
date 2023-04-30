using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LeitorCodigoDeBarras.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;
[assembly: Xamarin.Forms.Dependency(typeof(LeitorCodigoDeBarras.Droid.Service.QrCodeScanning))]
namespace LeitorCodigoDeBarras.Droid.Service
{
    public class QrCodeScanning : IQrCodeScanningService
    {        
        public async Task<string> ScanAsync()
        {
            var optionsCustom = new MobileBarcodeScanningOptions()
            {
                UseFrontCameraIfAvailable = false
            };
            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do código de barra",
                BottomText = "Toque na tela para focar"
            };

            var scanResults = await scanner.Scan(optionsCustom);

            return (scanResults != null) ? scanResults.Text : string.Empty;
        }
    }
}