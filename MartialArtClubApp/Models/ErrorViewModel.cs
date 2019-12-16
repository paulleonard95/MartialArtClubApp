using System;

namespace MartialArtClubApp.Models
{
    public class ErrorViewModel
    {
        // commit checvk
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}