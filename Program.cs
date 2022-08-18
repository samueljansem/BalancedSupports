
Console.WriteLine(BalancedSupports.AreBalanced("(){}[]")); //true
Console.WriteLine(BalancedSupports.AreBalanced("[{()}](){}")); //true
Console.WriteLine(BalancedSupports.AreBalanced("[]{()")); //false
Console.WriteLine(BalancedSupports.AreBalanced("[{)]")); //false
