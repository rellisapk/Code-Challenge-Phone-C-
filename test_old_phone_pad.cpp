#include <iostream>
#include <cassert>
#include "old_phone_pad.h"

using namespace std;

void testOldPhonePad() {
    // Test 1
    assert(OldPhonePad("33#") == "E");
    cout << "Test 1 Passed!\n";

    // Test 2
    assert(OldPhonePad("227#") == "B");
    cout << "Test 2 Passed!\n";

    // Test 3
    assert(OldPhonePad("4433555 555666#") == "HELLO");
    cout << "Test 3 Passed!\n";

    // Test 4:
    assert(OldPhonePad("8 88777444666*664#") == "TURNG");
    cout << "Test 4 Passed!\n";

    // Test 5
    assert(OldPhonePad("#") == "");
    cout << "Test 5 Passed!\n";
}

int main() {
    testOldPhonePad();
    cout << "Semua tes berhasil!\n";
    return 0;
}
