//"use strict";

document.addEventListener('dragover', function (e) { e.preventDefault(); }, false);

document.addEventListener('drop', function (e) { e.preventDefault(); }, false);

// window.addEventListener("contextmenu", window => {
//  window.preventDefault();
//});

function IsNull(val) {
  if(typeof val === typeof undefined) {
    return true;
  }

  if(val === undefined) {
    return true;
  }

  if(val === null) {
    return true;
  }

  return false;
}

window.IsNull = IsNull;

function IsNotNull(val) {
  if(typeof val === typeof undefined) {
    return false;
  }

  if(val === undefined) {
    return false;
  }

  if(val === null) {
    return false;
  }

  return true;
}

window.IsNotNull = IsNotNull;

window.ArraySourceMap = new Map();

// if(IsNotNull(window.chrome) && !window.chrome.hasOwnProperty('webview')){

// Object.defineProperty(object1, 'property1', {
//   value: 42,
//   writable: false
// });

// }
const PlotlyApp = {
  listenToAutosizeEvent: (div_container) => {
    div_container.on('plotly_autosize', function () { window.chrome.webview.postMessage({ event: 'PlotlyAutosize' }); });
    return div_container;
  },
  listenToEventEvent: (div_container) => {
    div_container.on('plotly_event', function () { window.chrome.webview.postMessage({ event: 'PlotlyEvent' }); });
    return div_container;
  },
  listenToClickEvent: (div_container, data_handler) => {
    div_container.on('plotly_click', function (eventData) { window.chrome.webview.postMessage({ event: 'PlotlyClick', data: data_handler(eventData) }); });
    return div_container;
  },
  listenToHoverEvent: (div_container, data_handler) => {
    div_container.on('plotly_hover', function (eventData) { window.chrome.webview.postMessage({ event: 'PlotlyHover', data: data_handler(eventData) }); });
    return div_container;
  },
  listenToUnhoverEvent: (div_container, data_handler) => {
    div_container.on('plotly_unhover', function (eventData) { window.chrome.webview.postMessage({ event: 'PlotlyUnhover', data: data_handler(eventData) }); });
    return div_container;
  },
  listenToSelectingEvent: (div_container, data_handler) => {
    div_container.on('plotly_selecting', function (eventData) { window.chrome.webview.postMessage({ event: 'PlotlySelecting', data: data_handler(eventData) }); });
    return div_container;
  },
  listenToSelectedEvent: (div_container, data_handler) => {
    div_container.on('plotly_selected', function (eventData) {
      const data = data_handler(eventData);

      window.chrome.webview.postMessage({ event: 'PlotlySelected', selected: data });
    });
    return div_container;
  },
  listenToDeselectEvent: (div_container) => {
    div_container.on('plotly_deselect', function () { window.chrome.webview.postMessage({ event: 'PlotlyDeselect' }); });
    return div_container;
  },
  listenToAnimatedEvent: (div_container) => {
    div_container.on('plotly_animated', function () { window.chrome.webview.postMessage({ event: 'PlotlyAnimated' }); });
    return div_container;
  },
  listenToRedrawEvent: (div_container) => {
    div_container.on('plotly_redraw', function () { window.chrome.webview.postMessage({ event: 'PlotlyRedraw' }); });
    return div_container;
  },
  listenToRestyleEvent: (div_container) => {
    div_container.on('plotly_restyle', function () { window.chrome.webview.postMessage({ event: 'PlotlyRestyle' }); });
    return div_container;
  },
  listenToRelayoutEvent: (div_container) => {
    div_container.on('plotly_relayout', function () { window.chrome.webview.postMessage({ event: 'PlotlyRelayout' }); });
    return div_container;
  },
  listenToRelayoutingEvent: (div_container) => {
    div_container.on('plotly_relayouting', function () { window.chrome.webview.postMessage({ event: 'PlotlyRelayouting' }); });
    return div_container;
  },
  listenToClickAnnotationEvent: (div_container) => {
    div_container.on('plotly_clickannotation', function () { window.chrome.webview.postMessage({ event: 'PlotlyClickAnnotation' }); });
    return div_container;
  },
  listenToLegendClickEvent: (div_container) => {
    div_container.on('plotly_legendclick', function () { window.chrome.webview.postMessage({ event: 'PlotlyLegendClick' }); });
    return div_container;
  },
  listenToLegendDoubleClickEvent: (div_container) => {
    div_container.on('plotly_legenddoubleclick', function () { window.chrome.webview.postMessage({ event: 'PlotlyLegendDoubleClick' }); });
    return div_container;
  },
  listenToAfterPlotEvent: (div_container) => {
    div_container.on('plotly_afterplot', function () { window.chrome.webview.postMessage({ event: 'PlotlyAfterPlot' }); });
    return div_container;
  },
  listenToBeforePlotEvent: (div_container) => {
    div_container.on('plotly_beforeplot', function () { window.chrome.webview.postMessage({ event: 'PlotlyBeforePlot' }); });
    return div_container;
  },
  listenToBeforeHoverEvent: (div_container) => {
    div_container.on('plotly_beforeover', function () { window.chrome.webview.postMessage({ event: 'PlotlyBeforeHover' }); });
    return div_container;
  },
  listenToDoubleClickEvent: (div_container) => {
    div_container.on('plotly_doubleclick', function () { window.chrome.webview.postMessage({ event: 'PlotlyDoubleClick' }); });
    return div_container;
  },
  listenToWebglContextLostEvent: (div_container) => {
    div_container.on('plotly_webglcontextlost', function () { window.chrome.webview.postMessage({ event: 'PlotlyWebglContextLost' }); });
    return div_container;
  },

  emitEvent: (eventName, data) => { window.chrome.webview.postMessage({ event: eventName, data: data }); },
  emitDOMContentLoadedEvent: () => { window.chrome.webview.postMessage({ event: 'DOMContentLoaded' }); },
  getDefaultConfiguration() {
    const config = {
      showLink: true,
      linkText: 'https://trmcnealy.github.io',
      mapboxAccessToken: 'pk.eyJ1IjoidHJtY25lYWx5IiwiYSI6ImNrZDN3aGNvMzBxNjQycW16Zml2M2UwZmcifQ.aT8sIrXsA2pHPSjw_U-fUA',
      plotGlPixelRatio: 2,
      displayModeBar: 'hover',
      frameMargins: 0,
      displaylogo: false,
      fillFrame: true,
      responsive: true,
      scrollZoom: true,
      modeBarButtons: false,
      modeBarButtonsToAdd: [],
      modeBarButtonsToRemove: ['hoverClosestCartesian', 'hoverCompareCartesian'],
      toImageButtonOptions: { format: 'svg', filename: 'custom_image', height: window.plotly_container.height, width: window.plotly_container.width, scale: 1 }
    };

    return config;
  },

  getManagedObject: (name) => { return eval(`window.chrome.webview.hostObjects.sync.${name}`); },

  makeNewArray: (plotly_plot, source, data_type, size_type) => {
    const dataSource = plotly_plot[source];

    if(data_type === 'string') {
      return dataSource;
    }

    const dataSourceLength = plotly_plot.Length(dataSource);
    const byteSize = dataSourceLength * size_type;

    const memory = new ArrayBuffer(byteSize);

    window.ArraySourceMap.set(source, { Memory: memory, SizeType: size_type, DataSourceLength: dataSourceLength, ByteSize: byteSize });

    if(data_type === 'float') {
      const newArray = new Float32Array(memory);
      newArray.set(plotly_plot[source]);
      return newArray;
    } else if(data_type === 'double') {
      const newArray = new Float64Array(memory);
      newArray.set(plotly_plot[source]);
      return newArray;
    } else if(data_type === 'int') {
      const newArray = new Int32Array(memory);
      newArray.set(plotly_plot[source]);
      return newArray;
    } else if(data_type === 'long') {
      const newArray = new BigInt64Array(memory);
      newArray.set(plotly_plot[source]);
      return newArray;
    }
    return null;
  },
  updateExistingArray: (plotly_plot, source, data_type, size_type) => {
    const oldArrayData = window.ArraySourceMap.get(source);

    const dataSource = plotly_plot[source];

    if(data_type === 'string') {
      return dataSource;
    }

    const dataSourceLength = plotly_plot.Length(dataSource);

    if(oldArrayData.DataSourceLength === dataSourceLength && oldArrayData.SizeType === size_type) {
      if(data_type === 'float') {
        const newArray = new Float32Array(oldArrayData.Memory);
        newArray.set(dataSource);
        return newArray;
      } else if(data_type === 'double') {
        const newArray = new Float64Array(oldArrayData.Memory);
        newArray.set(dataSource);
        return newArray;
      } else if(data_type === 'int') {
        const newArray = new Int32Array(oldArrayData.Memory);
        newArray.set(dataSource);
        return newArray;
      } else if(data_type === 'long') {
        const newArray = new BigInt64Array(oldArrayData.Memory);
        newArray.set(dataSource);
        return newArray;
      }
      return null;
    }

    if(data_type === 'float') {
      return window.PlotlyApp.makeNewArray(plotly_plot, source, 'float', 4);
    } else if(data_type === 'double') {
      return window.PlotlyApp.makeNewArray(plotly_plot, source, 'double', 8);
    } else if(data_type === 'int') {
      return window.PlotlyApp.makeNewArray(plotly_plot, source, 'int', 4);
    } else if(data_type === 'long') {
      return window.PlotlyApp.makeNewArray(plotly_plot, source, 'long', 8);
    }
    return null;
  },
  getSourceArray: (plotly_plot, source) => {
    const data_type = plotly_plot.GetDataSourceType(source);

    if(data_type === 'float') {
      if(window.ArraySourceMap.has(source)) {
        return window.PlotlyApp.updateExistingArray(plotly_plot, source, 'float', 4);
      } else {
        return window.PlotlyApp.makeNewArray(plotly_plot, source, 'float', 4);
      }
    } else if(data_type === 'double') {
      if(window.ArraySourceMap.has(source)) {
        return window.PlotlyApp.updateExistingArray(plotly_plot, source, 'double', 8);
      } else {
        return window.PlotlyApp.makeNewArray(plotly_plot, source, 'double', 8);
      }
    } else if(data_type === 'int') {
      if(window.ArraySourceMap.has(source)) {
        return window.PlotlyApp.updateExistingArray(plotly_plot, source, 'int', 4);
      } else {
        return window.PlotlyApp.makeNewArray(plotly_plot, source, 'int', 4);
      }
    } else if(data_type === 'long') {
      if(window.ArraySourceMap.has(source)) {
        return window.PlotlyApp.updateExistingArray(plotly_plot, source, 'long', 8);
      } else {
        return window.PlotlyApp.makeNewArray(plotly_plot, source, 'long', 8);
      }
    } else if(data_type === 'string') {
      return plotly_plot[source];
    }
    return null;
  },
  getSourceArrayMapTimesValue: (plotly_plot, source, value) => {
    const data_type = plotly_plot.GetDataSourceType(source);

    const array = window.PlotlyApp.getSourceArray(plotly_plot, source, value);

    if(data_type === 'float') {
      return array.map((element, index) => element * value);
    } else if(data_type === 'double') {
      return array.map((element, index) => element * value);
    } else if(data_type === 'int') {
      return array.map((element, index) => element * value);
    } else if(data_type === 'long') {
      return array.map((element, index) => element * value);
    }
    // else if (data_type === "string") {
    //}
    return null;
  },

  createNewPlotly: (plotly_data, plotly_layout, plotly_config, plotly_frames) => {
    let plotly_container = window[`plotly_container_${window.ID}`];

    if(window.EnableLogging) {
      console.log({ data: plotly_data, layout: plotly_layout, config: plotly_config, frames: plotly_frames });
    }
    window.Plotly.newPlot(plotly_container, { data: plotly_data, layout: plotly_layout, config: plotly_config, frames: plotly_frames });
  },
  updatePlotly: (plotly_plot, plotly_data, plotly_layout, plotly_frames) => {
    let plotly_container = window[`plotly_container_${window.ID}`];

    for(let i = 0;i < plotly_data.length;++i) {
      if(window.EnableLogging) {
        console.log(plotly_data[i]);
      }

      if(window.IsNull(plotly_data[i].text) && window.IsNotNull(plotly_data[i].textsrc)) {
        plotly_data[i].text = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].textsrc);
      }

      if(window.IsNull(plotly_data[i].x) && window.IsNotNull(plotly_data[i].xsrc)) {
        plotly_data[i].x = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].xsrc);
      }

      if(window.IsNull(plotly_data[i].y) && window.IsNotNull(plotly_data[i].ysrc)) {
        plotly_data[i].y = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].ysrc);
      }

      if(window.IsNull(plotly_data[i].lon) && window.IsNotNull(plotly_data[i].lonsrc)) {
        plotly_data[i].lon = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].lonsrc);
      }

      if(window.IsNull(plotly_data[i].lat) && window.IsNotNull(plotly_data[i].latsrc)) {
        plotly_data[i].lat = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].latsrc);
      }

      if(window.IsNotNull(plotly_data[i].dimensions) && plotly_data[i].dimensions.length > 0) {
        for(let j = 0;j < plotly_data[i].dimensions.length;++j) {
          if(window.IsNull(plotly_data[i].dimensions[j].values) && window.IsNotNull(plotly_data[i].dimensions[j].valuessrc)) {
            plotly_data[i].dimensions[j].values = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].dimensions[j].valuessrc);
          }
        }
      }

      if(window.IsNotNull(plotly_data[i].line) && window.IsNull(plotly_data[i].line.color) && window.IsNotNull(plotly_data[i].line.colorsrc)) {
        plotly_data[i].line.color = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].line.colorsrc);
      }

      if(window.IsNotNull(plotly_data[i].marker) && window.IsNull(plotly_data[i].marker.color) && window.IsNotNull(plotly_data[i].marker.colorsrc)) {
        plotly_data[i].marker.color = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].marker.colorsrc);
      }

      if(window.IsNotNull(plotly_data[i].marker) && window.IsNotNull(plotly_data[i].marker.sizesrc)) {
        if(window.IsNotNull(plotly_data[i].marker.size)) {
          plotly_data[i].marker.size = window.PlotlyApp.getSourceArrayMapTimesValue(plotly_plot, plotly_data[i].marker.sizesrc, plotly_data[i].marker.size);
        } else {
          plotly_data[i].marker.size = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].marker.sizesrc);
        }
      }
    }

    window.Plotly.addTraces(plotly_container, plotly_data);

    window.Plotly.relayout(plotly_container, plotly_layout);

    if(window.IsNotNull(plotly_frames) && plotly_frames.length > 0) {
      window.Plotly.addFrames(plotly_container, plotly_frames);
    }
  },

  updatePlotlyData: (plotly_plot, plotly_data) => {
    let plotly_container = window[`plotly_container_${window.ID}`];

    for(let i = 0;i < plotly_data.length;++i) {
      if(window.EnableLogging) {
        console.log(plotly_data[i]);
      }

      if(window.IsNull(plotly_data[i].text) && window.IsNotNull(plotly_data[i].textsrc)) {
        plotly_data[i].text = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].textsrc);
      }

      if(window.IsNull(plotly_data[i].x) && window.IsNotNull(plotly_data[i].xsrc)) {
        plotly_data[i].x = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].xsrc);
      }

      if(window.IsNull(plotly_data[i].y) && window.IsNotNull(plotly_data[i].ysrc)) {
        plotly_data[i].y = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].ysrc);
      }

      if(window.IsNull(plotly_data[i].lon) && window.IsNotNull(plotly_data[i].lonsrc)) {
        plotly_data[i].lon = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].lonsrc);
      }

      if(window.IsNull(plotly_data[i].lat) && window.IsNotNull(plotly_data[i].latsrc)) {
        plotly_data[i].lat = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].latsrc);
      }

      if(window.IsNotNull(plotly_data[i].dimensions) && plotly_data[i].dimensions.length > 0) {
        for(let j = 0;j < plotly_data[i].dimensions.length;++j) {
          if(window.IsNull(plotly_data[i].dimensions[j].values) && window.IsNotNull(plotly_data[i].dimensions[j].valuessrc)) {
            plotly_data[i].dimensions[j].values = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].dimensions[j].valuessrc);
          }
        }
      }

      if(window.IsNotNull(plotly_data[i].line) && window.IsNull(plotly_data[i].line.color) && window.IsNotNull(plotly_data[i].line.colorsrc)) {
        plotly_data[i].line.color = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].line.colorsrc);
      }

      if(window.IsNotNull(plotly_data[i].marker) && window.IsNull(plotly_data[i].marker.color) && window.IsNotNull(plotly_data[i].marker.colorsrc)) {
        plotly_data[i].marker.color = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].marker.colorsrc);
      }

      if(window.IsNotNull(plotly_data[i].marker) && window.IsNotNull(plotly_data[i].marker.sizesrc)) {
        if(window.IsNotNull(plotly_data[i].marker.size)) {
          plotly_data[i].marker.size = window.PlotlyApp.getSourceArrayMapTimesValue(plotly_plot, plotly_data[i].marker.sizesrc, plotly_data[i].marker.size);
        } else {
          plotly_data[i].marker.size = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].marker.sizesrc);
        }
      }
    }

    // if (plotly_data.length === window[`plotly_container_${window.ID}`].data.length) {
    //    const indices = new Array(window[`plotly_container_${window.ID}`].data.length).fill().map((element, index) => index);
    //    console.log(indices);
    //    window.Plotly.update(window[`plotly_container_${window.ID}`], plotly_data, indices);
    //} else {

    while(plotly_container.data.length > 0) {
      window.Plotly.deleteTraces(plotly_container, 0);
    }

    window.Plotly.addTraces(plotly_container, plotly_data);
    //}
  },
  updatePlotlyLayout: (plotly_layout) => {
    let plotly_container = window[`plotly_container_${window.ID}`];

    window.Plotly.relayout(plotly_container, plotly_layout);
  },
  updatePlotlyFrames: (plotly_plot, plotly_frames) => {
    let plotly_container = window[`plotly_container_${window.ID}`];

    for(let i = 0;i < plotly_frames.length;++i) {
      if(window.IsNotNull(plotly_frames[i].data) && window.IsNotNull(plotly_frames[i].data.dimensions) && plotly_frames[i].data.dimensions.length > 0) {
        for(let j = 0;j < plotly_frames[i].data.dimensions.length;++j) {
          if(window.IsNull(plotly_frames[i].data.dimensions[j].values) && window.IsNotNull(plotly_frames[i].data.dimensions[j].valuessrc)) {
            plotly_frames[i].data.dimensions[j].values = window.PlotlyApp.getSourceArray(plotly_plot, plotly_frames[i].data.dimensions[j].valuessrc);
          }
        }
      }
    }

    window.Plotly.addFrames(plotly_container, plotly_frames);
  },
  updateNewPlotly: (plotly_plot, plotly_data, plotly_layout, plotly_config, plotly_frames) => {
    let plotly_container = window[`plotly_container_${window.ID}`];

    for(let i = 0;i < plotly_data.length;++i) {
      if(window.EnableLogging) {
        console.log(plotly_data[i]);
      }

      if(window.IsNull(plotly_data[i].text) && window.IsNotNull(plotly_data[i].textsrc)) {
        plotly_data[i].text = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].textsrc);
      }

      if(window.IsNull(plotly_data[i].x) && window.IsNotNull(plotly_data[i].xsrc)) {
        plotly_data[i].x = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].xsrc);
      }

      if(window.IsNull(plotly_data[i].y) && window.IsNotNull(plotly_data[i].ysrc)) {
        plotly_data[i].y = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].ysrc);
      }

      if(window.IsNull(plotly_data[i].lon) && window.IsNotNull(plotly_data[i].lonsrc)) {
        plotly_data[i].lon = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].lonsrc);
      }

      if(window.IsNull(plotly_data[i].lat) && window.IsNotNull(plotly_data[i].latsrc)) {
        plotly_data[i].lat = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].latsrc);
      }

      if(window.IsNotNull(plotly_data[i].dimensions) && plotly_data[i].dimensions.length > 0) {
        for(let j = 0;j < plotly_data[i].dimensions.length;++j) {
          if(window.IsNull(plotly_data[i].dimensions[j].values) && window.IsNotNull(plotly_data[i].dimensions[j].valuessrc)) {
            plotly_data[i].dimensions[j].values = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].dimensions[j].valuessrc);
          }
        }
      }

      if(window.IsNotNull(plotly_data[i].line) && window.IsNull(plotly_data[i].line.color) && window.IsNotNull(plotly_data[i].line.colorsrc)) {
        plotly_data[i].line.color = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].line.colorsrc);
      }

      if(window.IsNotNull(plotly_data[i].marker) && window.IsNull(plotly_data[i].marker.color) && window.IsNotNull(plotly_data[i].marker.colorsrc)) {
        plotly_data[i].marker.color = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].marker.colorsrc);
      }

      if(window.IsNotNull(plotly_data[i].marker) && window.IsNotNull(plotly_data[i].marker.sizesrc)) {
        if(window.IsNotNull(plotly_data[i].marker.size)) {
          plotly_data[i].marker.size = window.PlotlyApp.getSourceArrayMapTimesValue(plotly_plot, plotly_data[i].marker.sizesrc, plotly_data[i].marker.size);
        } else {
          plotly_data[i].marker.size = window.PlotlyApp.getSourceArray(plotly_plot, plotly_data[i].marker.sizesrc);
        }
      }
    }

    while(plotly_container.data.length > 0) {
      window.Plotly.deleteTraces(plotly_container, 0);
    }

    window.Plotly.newPlot(plotly_container, { data: plotly_data, layout: plotly_layout, config: plotly_config, frames: plotly_frames });
  }
};

window.PlotlyApp = PlotlyApp;

function PlotlySelectedHandler(eventData) {
  if(IsNotNull(eventData) && IsNotNull(eventData.points)) {
    var selectedData = new Array(eventData.points.length);
    let i = 0;

    eventData.points.forEach(function (pt) {
      selectedData[i] = { curveNumber: pt.curveNumber, pointIndex: pt.pointIndex, pointNumber: pt.pointNumber, x: pt.x, y: pt.y };
      ++i;
    });

    return selectedData;
  }
  return null;
}

async function GetWasmExportsAsync(callback, wasmUrl, imports) {
  const wasmBrowserInstantiate = async (wasmModuleUrl, importObject) => {
    if(!importObject) {
      importObject = {
        env: {
          abort: () => { return console.log('Abort!'); }
        }
      };
    }

    const fetchAndInstantiateTask = async () => {
      const buf = await window.fetch(wasmModuleUrl).then((response) => response.arrayBuffer());

      const instantiated = await WebAssembly.instantiate(buf, importObject);

      return instantiated.instance;
    };

    return await fetchAndInstantiateTask();
  };

  const exports = (await wasmBrowserInstantiate(wasmUrl, imports)).exports;

  callback(exports);

  return exports;
}

function GetWasmExports(wasmUrl) {
  const importFunctions = {
    env: {
      log: function (value) { console.log(`${value}`); }
    }
  };

  // const buf = fs.readFileSync(wasmUrl);
  window.fetch(wasmUrl).then((response) => response.arrayBuffer()).then((bytes) => {
    const mod = new WebAssembly.Module(bytes);

    const instance = new WebAssembly.Instance(mod, importFunctions);

    return instance.exports;
  });
}

window.PlotlySelectedHandler = PlotlySelectedHandler;

window.GetWasmExportsAsync = GetWasmExportsAsync;

window.GetWasmExports = GetWasmExports;

// if (typeof(window.PlotlyWorker) == undefined) {
//  window.PlotlyWorker = new Worker("PlotlyWorker.js");
//}

// const buf = fs.readFileSync(wasmModuleUrl);
// window.fetch(wasmModuleUrl).then(
//  function (response) {
//    if (response.headers["Content-Type"] === "text/plain") {
//      return response.text();
//    }
//    if (response.headers["Content-Type"] === "application/json") {
//      return response.json();
//    }
//    if (response.headers["Content-Type"] === "multipart/form-data") {
//      return response.formData();
//    }
//    if (response.headers["Content-Type"] === "arraybuffer") {
//      return response.arrayBuffer();
//    }

//    return response.blob();
//  },
//  function (err) {
//    console.error(err);
//  }
//);
