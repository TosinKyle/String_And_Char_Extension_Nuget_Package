ExtensionUtilities
String and Char Extension Utilities is a C# library Class that provides a set of string and Character extension methods to enhance text processing:

Installation
Use the nuget package manager to install String Extension Utilities.

Usage
import String and Char ExtensionUtilities

Add Symbol After Every Word: Appends a specified symbol after each word in a sentence starting with upper case.
Count Vowels: Calculates the number of vowels in a string.
Count Consonants: Calculates the number of consonants in a string.
Validate Email: Checks if a string is a valid email address.
Check if Letter is Vowel: Determines if a character is a vowel.
Check if Letter is Consonant: Determines if a character is a consonant.

# returns 'She_ is A_ Girl_'
String and Char Extension Utilities.AddCharacterAfterEveryWordThatStartsWithUpperCase("She is A Girl",'_')
      
# returns true
String and Char Extension Utilities.IsCharacterVowel('o')

# returns true
String and Char Extension Utilities.IsCharacterConsonant('p')

# returns 1
String and Char Extension Utilities.CountVowel('yes')

# returns 2
String and Char Extension Utilities.CountConsonant('yes')

# returns 'true'
String and Char Extension Utilities.IsEmail('user@example.com')
Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

License
MIT
