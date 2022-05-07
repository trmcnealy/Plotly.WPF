

self.onmessage = (eventData) => {
  
  let {id, array, point} = eventData.data;
  
  array[id] = {
    curveNumber: point.curveNumber,
    pointIndex: point.pointIndex,
    pointNumber: point.pointNumber,
    x: point.x,
    y: point.y
  };

  close();
};

//"use strict";

//const base64data = "

//(function ({
//  function decode(b64{
//    const str = window.atob(b6;
//    const array = new Uint8Array(str.length

//    for(let i = 0;i < str.length;i += 1{
//      array[i] = str.charCodeAt(;
//   

//    return array.buff;
//  

//  const memSize = 2;
//  const memory = new WebAssembly.Memory({ initial: memSize, maximum: memSize }

//  const instance = new WebAssembly.Instan(
//    new WebAssembly.Module(new Uint8Array(decode(base64data),
//    { env: { memory } }

//  const height = canvas.heig;
//  const width = canvas.widt

//  const ctx = canvas.getContext("2,
//    { alpha: false, antialias: false, depth: false }

//  if(!ctx{
//    throw "Your browser does not support canva;
//}
//})();
