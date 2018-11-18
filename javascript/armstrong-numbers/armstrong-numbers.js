const validate = num => {
  const str = `${num}`;
  const result = str
    .split("")
    .map(n => Math.pow(n, str.length))
    .reduce((acc, val) => acc + val);

  return result === num;
};

module.exports = { validate };
