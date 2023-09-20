/*
 * Reto #1
 * ¿ES UN ANAGRAMA?
 * Fecha publicación enunciado: 03/01/22
 * Fecha publicación resolución: 10/01/22
 * Dificultad: MEDIA
 *
 * Enunciado: Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Boolean) según sean o no anagramas.
 * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
 * NO hace falta comprobar que ambas palabras existan.
 * Dos palabras exactamente iguales no son anagrama.
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 *
 */

namespace app;

public class Challenge01
{
  public static void Challenge()
  {
    Console.WriteLine(IsAnagrama("amor", "roma"));
  }

  private static bool IsAnagrama(string word1, string word2)
  {
    if (word1.ToLower() == word2.ToLower()) return false;

    foreach (char letter in word1.ToLower())
    {
      if (!word2.ToLower().Contains(letter)) return false;
    }
    return true;
    // return word1.ToLower().OrderBy(c => c).SequenceEqual(word2.ToLower().OrderBy(c => c));
  }















  /*   private static bool IsAnagrama(string word1, string word2)
    {
      if (word1.ToLower() == word2.ToLower())
      {
        return false;
      }

      bool result = word1.ToLower().OrderBy(c => c).SequenceEqual(word2.ToLower().OrderBy(c => c));
      return result;
    }

    private static bool MyAnagrama(string word1, string word2)
    {
      for (int i = 0; i < word1.Length; i++)
      {
        char letter = word1[i];

        if (!word2.Contains(letter))
        //if (!(word2.IndexOf(letter) != -1))
        //if (!(word2.Any(c => c == letter)))
        {
          return false;
        }
      }
      return true;
    } */
}