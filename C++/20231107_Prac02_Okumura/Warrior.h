#pragma once
#include "Hero.h"

class Warrior : public Hero {
public:
    void Attack() override {
        std::cout << "Warrior attacks with a sqord!!" << std::endl;
    }
};
