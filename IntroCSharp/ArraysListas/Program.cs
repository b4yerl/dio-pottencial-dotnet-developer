int[] testeArray = new int[3];

testeArray[0] = 1921;
testeArray[1] = 1942;
testeArray[2] = 2022;

// for(int i = 0; i < testeArray.Length; i++) {
// Console.WriteLine(testeArray[i]);
// }

// foreach (int valor in testeArray)
// {
//   Console.WriteLine(valor);
// }

int[] arrayDobrado = new int[testeArray.Length * 2];

// for(int i = 0; i < testeArray.Length; i++) {
//   arrayDobrado[i] = testeArray[i];
//   Console.WriteLine($"O item #{i + 1} do novo array, também é {arrayDobrado[i]}");
// }

Array.Copy(testeArray, arrayDobrado, testeArray.Length);
for(int i = 0; i < arrayDobrado.Length; i++) {
  Console.WriteLine(arrayDobrado[i]);
}