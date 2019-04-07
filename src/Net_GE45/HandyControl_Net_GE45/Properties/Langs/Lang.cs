﻿using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace HandyControl.Properties.Langs
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    internal class Lang : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private static void Set(ref string oldValue, string newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(oldValue, newValue)) return;
            oldValue = newValue;
            Instance.OnPropertyChanged(propertyName);
        }

        private Lang() { }

        private static Lang Instance => new Lazy<Lang>(() => new Lang()).Value;

        private static string _am = "上午";

        public static string Am
        {
            get => _am;
            set => Set(ref _am, value);
        }

        private static string _cancel = "取消";

        public static string Cancel
        {
            get => _cancel;
            set => Set(ref _cancel, value);
        }

        private static string _cannotRegisterCompositeCommandInItself = "无法自注册复合命令";

        public static string CannotRegisterCompositeCommandInItself
        {
            get => _cannotRegisterCompositeCommandInItself;
            set => Set(ref _cannotRegisterCompositeCommandInItself, value);
        }

        private static string _cannotRegisterSameCommandTwice = "不能注册同一命令两次";

        public static string CannotRegisterSameCommandTwice
        {
            get => _cannotRegisterSameCommandTwice;
            set => Set(ref _cannotRegisterSameCommandTwice, value);
        }

        private static string _clear = "清空";

        public static string Clear
        {
            get => _clear;
            set => Set(ref _clear, value);
        }

        private static string _close = "关闭";

        public static string Close
        {
            get => _close;
            set => Set(ref _close, value);
        }

        private static string _closeAll = "关闭所有";

        public static string CloseAll
        {
            get => _closeAll;
            set => Set(ref _closeAll, value);
        }

        private static string _closeOther = "关闭其他";

        public static string CloseOther
        {
            get => _closeOther;
            set => Set(ref _closeOther, value);
        }

        private static string _confirm = "确定";

        public static string Confirm
        {
            get => _confirm;
            set => Set(ref _confirm, value);
        }

        private static string _errorImgPath = "错误的图片路径！";

        public static string ErrorImgPath
        {
            get => _errorImgPath;
            set => Set(ref _errorImgPath, value);
        }

        private static string _errorImgSize = "非法的图片尺寸！";

        public static string ErrorImgSize
        {
            get => _errorImgSize;
            set => Set(ref _errorImgSize, value);
        }

        private static string _formatError = "格式错误";

        public static string FormatError
        {
            get => _formatError;
            set => Set(ref _formatError, value);
        }

        private static string _interval10m = "间隔10分钟";

        public static string Interval10m
        {
            get => _interval10m;
            set => Set(ref _interval10m, value);
        }

        private static string _interval1h = "间隔1小时";

        public static string Interval1h
        {
            get => _interval1h;
            set => Set(ref _interval1h, value);
        }

        private static string _interval1m = "间隔1分钟";

        public static string Interval1m
        {
            get => _interval1m;
            set => Set(ref _interval1m, value);
        }

        private static string _interval2h = "间隔2小时";

        public static string Interval2h
        {
            get => _interval2h;
            set => Set(ref _interval2h, value);
        }

        private static string _interval30m = "间隔30分钟";

        public static string Interval30m
        {
            get => _interval30m;
            set => Set(ref _interval30m, value);
        }

        private static string _interval30s = "间隔30秒";

        public static string Interval30s
        {
            get => _interval30s;
            set => Set(ref _interval30s, value);
        }

        private static string _interval5m = "间隔5分钟";

        public static string Interval5m
        {
            get => _interval5m;
            set => Set(ref _interval5m, value);
        }

        private static string _isNecessary = "不能为空";

        public static string IsNecessary
        {
            get => _isNecessary;
            set => Set(ref _isNecessary, value);
        }

        private static string _no = "否";

        public static string No
        {
            get => _no;
            set => Set(ref _no, value);
        }

        private static string _outOfRange = "不在范围内";

        public static string OutOfRange
        {
            get => _outOfRange;
            set => Set(ref _outOfRange, value);
        }

        private static string _pm = "下午";

        public static string Pm
        {
            get => _pm;
            set => Set(ref _pm, value);
        }

        private static string _pngImg = "PNG图片";

        public static string PngImg
        {
            get => _pngImg;
            set => Set(ref _pngImg, value);
        }

        private static string _tip = "提示";

        public static string Tip
        {
            get => _tip;
            set => Set(ref _tip, value);
        }

        private static string _tooLarge = "过大";

        public static string TooLarge
        {
            get => _tooLarge;
            set => Set(ref _tooLarge, value);
        }

        private static string _unknown = "未知";

        public static string Unknown
        {
            get => _unknown;
            set => Set(ref _unknown, value);
        }

        private static string _unknownSize = "未知大小";

        public static string UnknownSize
        {
            get => _unknownSize;
            set => Set(ref _unknownSize, value);
        }

        private static string _yes = "是";

        public static string Yes
        {
            get => _yes;
            set => Set(ref _yes, value);
        }
    }
}