# Challenge 1
## Prompt
Give me a coding challenge for a junior programmer using only C#
## Repsonse
### Challenge: Top Word Frequency Analyzer
### The Scenario:
You are building a basic text-analysis tool for a blogging platform. The content team wants a feature that automatically extracts the most frequently used words from an article to help generate tags.

Your task is to write a method that analyzes a block of text and returns the top N most frequent words, along with their occurrence counts.

Method Signature:
```
C#
public static Dictionary<string, int> GetTopWords(string text, int topN)
{
    // Your code here
}
```
### The Requirements
Case Insensitivity: The analysis must be case-insensitive. ("The" and "the" count as the same word). All returned keys should be lowercase.

Punctuation Handling: You must strip out standard punctuation (commas, periods, exclamation marks, question marks) before counting.

Whitespace: Treat spaces, tabs, and newlines as word separators.

Sorting: The returned dictionary must be ordered by frequency in descending order (highest count first).

Tie-Breaker: If two words have the exact same frequency, sort them alphabetically to determine which makes it into the top N.

Edge Cases: If the input string is null or empty, return an empty dictionary. If topN is greater than the number of unique words, just return all the unique words sorted correctly.

### Example Test Cases
Test Case 1: Standard Input
```
C#
string text = "The quick brown fox jumps over the lazy dog. The fox is quick!";
int topN = 3;

// Expected Output:
// Key: "the", Value: 3
// Key: "fox", Value: 2
// Key: "quick", Value: 2
(Note: "fox" and "quick" both appear twice, but "fox" comes first alphabetically).
```
Test Case 2: Edge Case (Empty String)
```
C#
string text = "";
int topN = 5;

// Expected Output: Count = 0 (Empty Dictionary)
Test Case 3: N is larger than unique words
```
```
C#
string text = "Apple apple banana";
int topN = 10;
// Expected Output: 
// Key: "apple", Value: 2
// Key: "banana", Value: 1
```
#Challenge 2
## Prompt 
Give me a coding challenge for a junior programmer using only C#
## Response
Here is a practical C# coding challenge designed for a junior developer. It tests your knowledge of string manipulation, loops, and basic error handling.
### The Challenge: Run-Length Encoding (RLE)
Run-length encoding is a simple form of data compression where consecutive data elements (in this case, characters in a string) are stored as a single data value and count.Your task is to build a C# class that can both compress and decompress strings using this method.
### Requirements
#### Compress(string input):
Take a string of alphabetic characters (e.g., "AABBBCCCC").Return a compressed string where repeating characters are replaced by the character and the number of times it repeats (e.g., "A2B3C4"). If a character only appears once consecutively, it should just have a 1 after it (e.g., "AB" becomes "A1B1"). If the compressed string is not shorter than the original string, return the original string. 
#### Decompress(string input):
Take a compressed string (e.g., "A2B3C4"). Return the original expanded string ("AABBBCCCC"). 
#### Edge Cases to Handle: 
Empty strings or null inputs. Case sensitivity ("aA" should be treated as two distinct characters: "a1A1").Test CasesCompression:"AABBBCCCC" $\rightarrow$ "A2B3C4""abc" $\rightarrow$ "abc" (Wait, "a1b1c1" is 6 characters long, which is longer than the original 3. So return "abc")"aaAAa" $\rightarrow$ "a2A2a1"Decompression:"A2B3C4" $\rightarrow$ "AABBBCCCC""a3b1c5" $\rightarrow$ "aaabccccc"
