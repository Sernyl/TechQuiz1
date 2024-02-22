import java.awt.Color;

public class Series {
    public void runSeries() {
        Monster monster = new Monster();

        Hero[] heroes = {
            new Hero(Color.BLUE),
            new Hero(Color.RED),
            new Hero(Color.YELLOW),
            new Hero(Color.BLACK),
            new Hero(Color.PINK)
        };
        HeroCommand heroCommand = new HeroCommand(heroes);

        heroCommand.kill(monster);

        monster.setBig();

        heroCommand.getZords();

        heroCommand.kill(monster);
    }
}

class Monster {
    public void setBig() {
    }
}

class Hero {
    private final Color color;

    public Hero(Color color) {
        this.color = color;
    }
}

class HeroCommand {
    private final Hero[] command;

    public HeroCommand(Hero[] command) {
        this.command = command;
    }

    public void kill(Monster monster) {
    }

    public void getZords() {
    }
}