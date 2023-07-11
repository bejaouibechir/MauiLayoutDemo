﻿using Microsoft.Maui.Layouts;

namespace FlexLayoutDemo.CustomLayout;
public class CascadeLayout : StackLayout
{
    protected override ILayoutManager CreateLayoutManager()
    {
        return new CascadeLayoutManager(this);
    }
}

