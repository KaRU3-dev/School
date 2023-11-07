import Class.Agents.Ranger;
import Class.Agents.Warrior;
import Class.Agents.Wizard;
import Class.Templates.Hero;

public class Main {
    public static void main(String[] args){
        Hero warrior = new Warrior();
        Hero wizard = new Wizard();
        Hero ranger = new Ranger();

        warrior.Attack();
        wizard.Attack();
        ranger.Attack();
    }
}
