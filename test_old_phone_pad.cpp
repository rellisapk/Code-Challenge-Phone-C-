#include <iostream>
#include <cassert>
#include "old_phone_pad.h"

void testOldPhonePad() {
    assert(OldPhonePad("33#") == "E");
    std::cout << "Test 1: Passed ✅\n";

    assert(OldPhonePad("227#") == "B");
    std::cout << "Test 2: Passed ✅\n";

    assert(OldPhonePad("4433555 555666#") == "HELLO");
    std::cout << "Test 3: Passed ✅\n";

    assert(OldPhonePad("8 88777444666*664#") == "TURNG");
    std::cout << "Test 4: Passed ✅\n";

    assert(OldPhonePad("#") == "");
    std::cout << "Test 5: Passed ✅\n";
}

int main() {
    testOldPhonePad();
    std::cout << "All test has passed! 🎉\n";
    return 0;
}
