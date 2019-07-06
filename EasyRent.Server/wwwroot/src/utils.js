class Utils {
  static isEmpty(obj) {
    return Object.keys(obj)
      .map((key) => {
        return obj.hasOwnProperty(key);
      })
      .some((field) => field === true);
  }
}

export default Utils;
