#include <iostream>
#include "Warrior.h"
#include "Wizard.h"
#include "Ranger.h"

int main() {

    // Initialization

    Hero* warrior = new Warrior();
    Hero* wizard = new Wizard();
    Hero* ranger = new Ranger();


    // Call attack

    warrior->Attack();
    wizard->Attack();
    ranger->Attack();

    // Delete pointer from memory
    delete warrior;
    delete wizard;
    delete ranger;

    // End code with 0
    return 0;
}
