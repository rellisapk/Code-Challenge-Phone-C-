Old Phone Keypad Decoder (C++)
A simple C++ program that converts old mobile keypad input into text.

How It Works
- Pressing 2 once = A, twice = B, three times = C.
- * = Backspace (deletes last character).
- # = End of input.
  
Examples
Input
33#
4433555 555666#

Output
E
HELLO

How to Run
Compile the program:
g++ old_phone_keypad.cpp -o decoder
