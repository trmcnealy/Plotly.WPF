"use strict";

const base64data = "";

(function () {
  function decode(b64) {
    const str = window.atob(b64);
    const array = new Uint8Array(str.length);

    for(let i = 0;i < str.length;i += 1) {
      array[i] = str.charCodeAt(i);
    }

    return array.buffer;
  };

  const memSize = 256;
  const memory = new WebAssembly.Memory({ initial: memSize, maximum: memSize });

  const instance = new WebAssembly.Instance(
    new WebAssembly.Module(new Uint8Array(decode(base64data))),
    { env: { memory } });

  const height = canvas.height;
  const width = canvas.width;

  const ctx = canvas.getContext("2d",
    { alpha: false, antialias: false, depth: false });

  if(!ctx) {
    throw "Your browser does not support canvas";
  }
})();
