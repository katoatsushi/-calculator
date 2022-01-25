using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AppKit;
using Foundation;
//using System;

namespace calculator{
    public partial class ViewController : NSViewController {
        private List<string> localValue = new List<string> { };
        
        public ViewController(IntPtr handle) : base(handle){
        }

        public override void ViewDidLoad(){
            base.ViewDidLoad();
            //ResultLabel.StringValue = "wolcome...";
        }

        public override NSObject RepresentedObject{
            get{
                return base.RepresentedObject;
            }
            set{
                base.RepresentedObject = value;
            }
        }

        public bool isIntegerOrFloat(){
            // 初期状態の場合は数値入力OK
            int listCount = localValue.Count;
            if (listCount == 0) return false;
            string lastVal = localValue.Last();
            if (lastVal == "÷" || lastVal == "×" || lastVal == "-" || lastVal == "+"){
                return false;
            }else{
                return true;
            }
        }

        public string updateLastDate(string thisNUm){
            string lastVal = localValue.Last();
            lastVal += thisNUm;
            Console.WriteLine(lastVal);
            localValue.RemoveAt(localValue.Count - 1);
            localValue.Add(lastVal);
            return lastVal;
        }

        // すでに記号がある場合は、その記号を破棄し新たに追加
        // すでに計算処理がある場合は、計算を行い、出力　[5,+,6] << *  => [11,*]
        public void checkValuesBeforeFunctionPut(){
            if (!isIntegerOrFloat()){
                localValue.RemoveAt(localValue.Count - 1);
            }
            if (localValue.Count == 3){
                putResult();
            }
        }

        public void putResult(){
            double res = 0.0;

            if (localValue.Count == 3){
                // 例: ["13", "+", "16"]で = を押された場合
                double value = double.Parse(localValue[0], CultureInfo.InvariantCulture.NumberFormat);
                double value2 = double.Parse(localValue[2], CultureInfo.InvariantCulture.NumberFormat);
                if (localValue[1] == "÷"){
                    res = value / value2;
                }else if (localValue[1] == "×"){
                    res = value * value2;
                }else if (localValue[1] == "+"){
                    res = value + value2;
                }else if (localValue[1] == "-"){
                    res = value - value2;
                }
            }
            else if(localValue.Count == 2){
                // 例: ["13", "+"]で=を押された場合
                double value = double.Parse(localValue[0], CultureInfo.InvariantCulture.NumberFormat);
                if (localValue[1] == "÷"){
                    res = value / value;
                }else if (localValue[1] == "×"){
                    res = value * value;
                }else if (localValue[1] == "+"){
                    res = value + value;
                }else if (localValue[1] == "-"){
                    res = value - value;
                }
            }else{
                res = 0;
            }
            // 浮動小数を整数に直せるなら直す
            int intVal = (int)res;
            double backToDouble = intVal;
            string stringRes = "";
            // 浮動小数 => 整数にし、その差が0なら整数に直せる、0でなかったらFloat
            if (res - backToDouble == 0){
                // 整数に変換できる
                stringRes = intVal.ToString();
            }
            else{
                // 少数点付きのまま文字列に直す
                stringRes = res.ToString();
            }

            // 初期化
            localValue = new List<string> { stringRes, };
            ResultLabel.StringValue = stringRes;
        }

        partial void buttonDivide(Foundation.NSObject sender){
            if (localValue.Count > 0)
            {
                checkValuesBeforeFunctionPut();
                localValue.Add("÷");
            }

        }
        partial void buttonTimes(Foundation.NSObject sender){
            if (localValue.Count > 0)
            {
                checkValuesBeforeFunctionPut();
                localValue.Add("×");
            }
        }
        partial void buttonSubtract(Foundation.NSObject sender){
            if (localValue.Count > 0)
            {
                checkValuesBeforeFunctionPut();
                localValue.Add("-");
            }
        }
        partial void buttonAdd(Foundation.NSObject sender){
            if (localValue.Count > 0)
            {
                checkValuesBeforeFunctionPut();
                localValue.Add("+");
            }
        }
        partial void buttonResult(Foundation.NSObject sender){
            putResult();
        }

        // 初期化
        partial void AcButton(Foundation.NSObject sender){
            localValue = new List<string> { };
            ResultLabel.StringValue = "0";
        }

        partial void buttonOne(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("1");
            }else{
                localValue.Add("1");
                ResultLabel.StringValue = "1";
            }
        }
        partial void buttonTwo(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("2");
            }else{
                localValue.Add("2");
                ResultLabel.StringValue = "2";
            }
        }
        partial void buttonThree(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("3");
            }else{
                localValue.Add("3");
                ResultLabel.StringValue = "3";
            }
        }
        partial void buttonFour(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("4");
            }else{
                localValue.Add("4");
                ResultLabel.StringValue = "4";
            }
        }
        partial void buttonFive(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("5");
            }else{
                localValue.Add("5");
                ResultLabel.StringValue = "5";
            }
        }
        partial void buttonSix(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("6");
            }else{
                localValue.Add("6");
                ResultLabel.StringValue = "6";
            }
        }
        partial void buttonSeven(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("7");
            }else{
                localValue.Add("7");
                ResultLabel.StringValue = "7";
            }
        }
        partial void buttonEight(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate("8");
            }else{
                localValue.Add("8");
                ResultLabel.StringValue = "8";
            }
        }
        partial void buttonNine(Foundation.NSObject sender){
            if (isIntegerOrFloat()) {
                ResultLabel.StringValue = updateLastDate("9");
            }else{
                localValue.Add("9");
                ResultLabel.StringValue = "9";
            }
        }
        partial void buttonZero(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
              ResultLabel.StringValue = updateLastDate("0");
            }
            else{
                localValue.Add("0");
                ResultLabel.StringValue = "0";
            }
        }
        partial void buttonDot(Foundation.NSObject sender){
            if (isIntegerOrFloat()){
                ResultLabel.StringValue = updateLastDate(".");
            }else{
                localValue.Add("0.");
                ResultLabel.StringValue = "0.";
            }
            //ResultLabel.StringValue = ".";
        }
    }
}