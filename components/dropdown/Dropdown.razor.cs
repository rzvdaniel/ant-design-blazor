﻿using System;
using AntDesign.Internal;
using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    public partial class Dropdown : OverlayTrigger
    {
        [Parameter]
        public Func<RenderFragment, RenderFragment, RenderFragment> ButtonsRender { get; set; }

        private string _rightButtonIcon = "ellipsis";
        private string _buttonSize = AntSizeLDSType.Default;
        private string _buttonType = ButtonType.Default;

        private RenderFragment _leftButton;
        private RenderFragment _rightButton;

        protected void ChangeRightButtonIcon(string icon)
        {
            _rightButtonIcon = icon;

            StateHasChanged();
        }

        protected void ChangeButtonSize(string size)
        {
            _buttonSize = size;

            StateHasChanged();
        }

        protected void ChangeButtonType(string type)
        {
            _buttonType = type;

            StateHasChanged();
        }
    }
}
