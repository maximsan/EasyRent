class Utils {
  static withKeys(obj) {
    return Object.keys(obj)
      .map((key) => {
        return obj.hasOwnProperty(key);
      })
      .some((field) => field === true);
  }

  static withValues(obj) {
    return Object.values(obj).some(
      (value) => value === undefined || value === '',
    );
  }

  static isEmpty() {
    return !Utils.withKeys() && !Utils.withValues();
  }
}

export default Utils;
