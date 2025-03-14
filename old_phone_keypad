#include "old_phone_pad.h"

std::string OldPhonePad(std::string messages) {
    std::string result = "";  
    std::string keys[] = {" ", " ", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};

    char lastChar = ' ';
    int count = 0;

    for (int i = 0; i < messages.length(); i++) {
        char item = messages[i];

        if (item == '#') break;  // If found # then stop
        if (item == '*') {  
            if (!result.empty()) result.pop_back(); // Delete the last char if contains *
            continue;
        }

        if (item == lastChar) {
            count++;  // Important things, to count the keypad touch
        } else {
            if (lastChar >= '0' && lastChar <= '9') {
                int index = lastChar - '0';
                int pos = (count - 1) % keys[index].size();
                result += keys[index][pos]; // Get letter
            }
            lastChar = item;
            count = 1;
        }
    }

    // Add the last char
    if (lastChar >= '0' && lastChar <= '9') {
        int index = lastChar - '0';
        int pos = (count - 1) % keys[index].size();
        result += keys[index][pos];
    }

    return result;
}
