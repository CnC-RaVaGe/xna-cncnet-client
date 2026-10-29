using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Rampastring.XNAUI.XNAControls;

namespace ClientGUI
{
    public class XNAGalleryImageButton : XNAImageButton
    {
        public XNAGalleryImageButton(WindowManager windowManager) : base(windowManager)
        {
            ViewerName = "GalleryViewer";
            ViewerBorderColor = Microsoft.Xna.Framework.Color.White;
            ViewerBorderThickness = 1;
            LoopViewer = true;
        }
    }

    public class XNAGalleryImageViewer : XNAImageViewer
    {
        public XNAGalleryImageViewer(WindowManager windowManager) : base(windowManager)
        {
            DrawBorders = true;
            BorderColor = Microsoft.Xna.Framework.Color.White;
            BorderThickness = 1;
            LoopImages = true;
        }
    }
}

namespace ClientGUI
{
    public static class ClientGalleryControlRegistration
    {
        public static IServiceCollection AddGalleryImageControls(this IServiceCollection services)
        {
            services.AddSingletonXnaControl<XNAGalleryImageButton>();
            services.AddSingletonXnaControl<XNAGalleryImageViewer>();
            return services;
        }
    }
}
