using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using CocosNet.Base;
using Color = CocosNet.Base.Color;

namespace CocosNet.Menus {
    public abstract class MenuItem : CocosNode {
		public event EventHandler Click;
		
		public MenuItem() {
			IsEnabled = true;
		}
		
		public RectangleF Rect {
			get { 
				return new RectangleF(Position.X - ContentSize.Width * AnchorPoint.X, 
					Position.Y - ContentSize.Height * AnchorPoint.Y, 
					ContentSize.Width, 
					ContentSize.Height);	
			}
		}
		
		public bool IsEnabled { get; set; }
		
		public Color Color { get; set; }
		
		public void Activate() {
			if (IsEnabled && Click != null) {
				Click(this, EventArgs.Empty);
			}
		}
		
		public abstract void OnSelected();
		public abstract void OnUnselected();
    }
}
