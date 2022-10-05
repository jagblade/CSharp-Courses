function solve(num, cmd1,cmd2,cmd3,cmd4,cmd5){
    let number = Number(num);

    number = switcher(number, cmd1);
    number = switcher(number, cmd2);
    number = switcher(number, cmd3);
    number = switcher(number, cmd4);
    number = switcher(number, cmd5);

    function switcher(num,cmd){
    
        switch (cmd) {
            case "chop":
                num /= 2;    
                break;
            case "dice":
                num = Math.sqrt(num);    
                break;
            case "bake":
                num *= 3;
                break;
            case "fillet":
                num *= 0.8 ;
                break;
            case  "spice":
                num += 1;
        }
        console.log(num)
        return num;
    }
}



solve('9', 'dice', 'spice', 'chop', 'bake',

'fillet')