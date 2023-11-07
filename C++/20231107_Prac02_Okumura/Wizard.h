#pragma once
#include "Hero.h"

class Wizard : public Hero {
public:
    void Attack() override {
        std::cout << "Wizard attacks with magic!!" << std::endl;
    }
};
