using System.Numerics;

var resultInt = AddAll(new[] { 1, 2, 3, 4, 5 });
Console.WriteLine(resultInt);

var resultDouble = AddAll(new[] { 1, .2, 3, 4, 5 });
Console.WriteLine(resultDouble);

Console.ReadKey();

static T AddAll<T>(IEnumerable<T> values) where T: INumber<T>
{
    return values.Aggregate(T.Zero, (current, value) => current + value);
}

//T AddAll<T>(T[] values) where T : INumber<T>
//{
//    var result = T.Zero;
//    foreach (var value in values)
//    {
//        result += value;
//    }

//    return result;
//}