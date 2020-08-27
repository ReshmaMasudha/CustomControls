using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomControls.Controls;
using CustomControls.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundButtonControl), typeof(RoundButtonControlRenderer))]

namespace CustomControls.Droid.Renderers
{
    [Obsolete]
    public class RoundButtonControlRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid());
                gradientDrawable.SetShape(ShapeType.Rectangle);
                gradientDrawable.SetStroke(4, Element.BorderColor.ToAndroid());
                gradientDrawable.SetCornerRadius(38.0f);
                Control.SetBackground(gradientDrawable);
            }
        }
    }
}