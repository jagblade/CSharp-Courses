function solve(names) {
      let result = names
      .sort((a, b) => a.localeCompare(b))
      .forEach((name , i) => console.log(`${i + 1}.${name}`));
    
    }
    solve(["John", "Bob", "Christina", "Ema"]);