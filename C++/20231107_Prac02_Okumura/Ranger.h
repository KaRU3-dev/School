#pragma once
#include "Hero.h"

class Ranger : public Hero {
public:
    void Attack() override {
        std::cout << "Ranger attacks with a bow and arrows!!" << std::endl;
    }
};
