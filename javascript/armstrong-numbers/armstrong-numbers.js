const reducer = (acc, val, _idx, arr) => acc + Math.pow(val, arr.length);

export const validate = num => {
  const arr = [...`${num}`];
  return arr.reduce(reducer, 0) === num;
};
