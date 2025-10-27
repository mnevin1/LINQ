using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach (Character character in characters.Skip(5).Take(5))
// {
//     Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());


// // are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");
// // how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
// // which characters were created in 1995 (name & description only)
// foreach (CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO { Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//     Console.WriteLine(characterDTO.Display());
// }

// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// // how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// // how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// // how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// // which characters (name only) appear in Mario and Donkey Kong?
// foreach (String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }
// // how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");

// // which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }

// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// // which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach (var characterByYearCreated in CharactersByYearCreated)
// {
//     Console.WriteLine(characterByYearCreated.Key);
//     foreach (var character in characterByYearCreated)
//     {
//         Console.WriteLine($"\t{character.Name}");
//     }
// }

// // How many character(s) were created in 1981 (all series)?
// int charactersCreatedIn1981 = characters.Count(c => c.YearCreated == 1981);
// Console.WriteLine($"Characters created in 1981 (all series): {charactersCreatedIn1981}");

// // List the character(s) created in that 1981 (all series) - return character name and series only.
// Console.WriteLine("Characters created in 1981 (all series):");
// foreach (var character in characters.Where(c => c.YearCreated == 1981).Select(c => new { c.Name, c.Series }))
// {
//     Console.WriteLine($"\t{character.Name} - Series: {string.Join(", ", character.Series)}");
// }

// How many character(s) were created in 1981 (Mario series)?
// int marioCharactersCreatedIn1981 = characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Mario"));
// Console.WriteLine($"Characters created in 1981 (Mario series): {marioCharactersCreatedIn1981}");

// List the character(s) created in that 1981 (Mario series) - return character name only.
// Console.WriteLine("Characters created in 1981 (Mario series):");
// foreach (string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }

// // How many character(s) were created in 1981 (Donkey Kong series)?
// int dkCharactersCreatedIn1981 = characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong"));
// Console.WriteLine($"Characters created in 1981 (Donkey Kong series): {dkCharactersCreatedIn1981}");

// List the character(s) created in that 1981 (Donkey Kong series) - return character name only.
// Console.WriteLine("Characters created in 1981 (Donkey Kong series):");
// foreach (string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }

// // How many character(s) made their first appearance in Donkey Kong 64?
// int charactersFromDK64 = characters.Count(c => c.FirstAppearance == "Donkey Kong 64");
// Console.WriteLine($"Characters that first appeared in Donkey Kong 64: {charactersFromDK64}");

// // List the character(s) that made their first appearance in Donkey Kong 64 - return character name only.
// Console.WriteLine("Characters that first appeared in Donkey Kong 64:");
// foreach (string? name in characters.Where(c => c.FirstAppearance == "Donkey Kong 64").Select(c => c.Name))
// {
//     Console.WriteLine($"\t{name}");
// }

// Are there any character(s) with no alias (all series)?
// bool charactersWithNoAlias = characters.Any(c => c.Alias.Count == 0);
// Console.WriteLine($"Are there characters with no alias (all series): {charactersWithNoAlias}");

// // How many character(s) with no alias (all series)?
// int charactersWithNoAliasCount = characters.Count(c => c.Alias.Count == 0);
// Console.WriteLine($"Characters with no alias (all series): {charactersWithNoAliasCount}");

// // List the character(s) with no alias (all series) - return character name, alias and series only.
// Console.WriteLine("Characters with no alias (all series):");
// foreach (var character in characters.Where(c => c.Alias.Count == 0).Select(c => new { c.Name, c.Alias, c.Series }))
// {
//     Console.WriteLine($"\t{character.Name} - Alias: [{string.Join(", ", character.Alias)}] - Series: {string.Join(", ", character.Series)}");
// }

// // Are there any character(s) with no alias (Mario series)?
// bool marioCharactersWithNoAlias = characters.Any(c => c.Alias.Count == 0 && c.Series.Contains("Mario"));
// Console.WriteLine($"Are there characters with no alias (Mario series): {marioCharactersWithNoAlias}");

// // How many character(s) with no alias (Mario series)?
// int marioCharactersWithNoAliasCount = characters.Count(c => c.Alias.Count == 0 && c.Series.Contains("Mario"));
// Console.WriteLine($"Characters with no alias (Mario series): {marioCharactersWithNoAliasCount}");

// List the character(s) with no alias (Mario series) - return character name and alias only.
// Console.WriteLine("Characters with no alias (Mario series):");
// foreach (var character in characters.Where(c => c.Alias.Count == 0 && c.Series.Contains("Mario")).Select(c => new { c.Name, c.Alias }))
// {
//     Console.WriteLine($"\t{character.Name} - Alias: [{string.Join(", ", character.Alias)}]");
// }

// // Are there any character(s) with no alias (Donkey Kong series)?
// bool dkCharactersWithNoAlias = characters.Any(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"));
// Console.WriteLine($"Are there characters with no alias (Donkey Kong series): {dkCharactersWithNoAlias}");

// // How many character(s) with no alias (Donkey Kong series)?
// int dkCharactersWithNoAliasCount = characters.Count(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong"));
// Console.WriteLine($"Characters with no alias (Donkey Kong series): {dkCharactersWithNoAliasCount}");

// // List the character(s) with no alias (Donkey Kong series) - return character name and alias only.
// Console.WriteLine("Characters with no alias (Donkey Kong series):");
// foreach (var character in characters.Where(c => c.Alias.Count == 0 && c.Series.Contains("Donkey Kong")).Select(c => new { c.Name, c.Alias }))
// {
//     Console.WriteLine($"\t{character.Name} - Alias: [{string.Join(", ", character.Alias)}]");
// }

// Do any character(s) have an alias of Snowmad King (return type must be boolean)?
bool charactersWithSnowmadKingAlias = characters.Any(c => c.Alias.Contains("Snowmad King"));
Console.WriteLine($"Do any characters have alias 'Snowmad King': {charactersWithSnowmadKingAlias}");