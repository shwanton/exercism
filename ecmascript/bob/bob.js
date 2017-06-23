class Bob {
  hey(message) {
    let onlyNumbers = /^[\d, \?]*$/.test(message)
    let isYelling = message === message.toUpperCase() && !onlyNumbers;
    let isQuestion = /.*\?$/.test(message);
    let isSilent = /^\s*$/.test(message)

    if (isSilent) return "Fine. Be that way!";
    if (isYelling) return "Whoa, chill out!";
    if (isQuestion) return "Sure.";

    return "Whatever.";
  }
}

export default Bob;

